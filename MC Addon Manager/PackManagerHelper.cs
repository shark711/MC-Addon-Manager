using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC_Addon_Manager
{
    public enum LogLevel
    {
        DEBUG = 0,
        INFO = 1,
        WARN = 2,
        ERROR = 3
    }

    public static class PackManagerHelper
    {
        public static async Task RefreshPacksAsync(
            string packsPath,
            string worldPacksPath,
            ListView lstAvailableMods,
            ListView lstInstalledMods,
            CheckBox chkBoxPacks,
            TabControl tabCtrlMinecraft,
            TabPage tabDirectories,
            TextBox txtPacks,
            Button btnRefresh,
            string packsType, // "behavior" or "resource"
            TextBox txtLog
        )
        {
            if (txtLog != null)
            {
                Log(txtLog, $"Refreshing {packsType} packs", LogLevel.INFO);
            }

            if (btnRefresh != null)
            {
                btnRefresh.Enabled = false;
                btnRefresh.Text = "Refreshing...";
            }
                

            if (chkBoxPacks.Checked == false)
            {
                if (btnRefresh != null)
                {
                    btnRefresh.Enabled = true;
                    btnRefresh.Text = "&Refresh";
                }
                    
                tabCtrlMinecraft.SelectedTab = tabDirectories;

                if (txtLog != null)
                {
                    Log(txtLog, $"Please select a valid {packsType} packs directory.", LogLevel.ERROR);
                }
                MessageBox.Show($"Please select a valid {packsType} packs directory.", "Directory Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPacks.Focus();
                return;
            }
            lstAvailableMods.Items.Clear();
            lstInstalledMods.Items.Clear();

            if (Directory.Exists(packsPath))
            {
                var directories = Directory.GetDirectories(packsPath);

                // Run the IO-bound work on a background thread
                var modItems = await Task.Run(() =>
                {
                    var items = new List<ListViewItem>();
                    foreach (var dir in directories)
                    {
                        string manifestPath = Path.Combine(dir, "manifest.json");
                        if (File.Exists(manifestPath))
                        {
                            var dirName = Path.GetFileName(dir);
                            try
                            {
                                // Pass 1: Remove // comments
                                string json = Regex.Replace(
                                    File.ReadAllText(manifestPath),
                                    @"^\s*(\\|//).*?$",
                                    "",
                                    RegexOptions.Multiline);
                                

                                // PAss 2: Remove multi-line /* ... */ comments
                                json = Regex.Replace(
                                    json,
                                    @"/\*.*?\*/",
                                    "",
                                    RegexOptions.Singleline
                                );

                                using (JsonDocument doc = JsonDocument.Parse(json))
                                {
                                    var root = doc.RootElement;
                                    if (root.TryGetProperty("header", out JsonElement header))
                                    {
                                        string name = header.GetProperty("name").GetString() ?? "";
                                        string description = header.GetProperty("description").GetString() ?? "";
                                        string uuid = header.GetProperty("uuid").GetString() ?? "";
                                        string versionStr = "";
                                        if (header.TryGetProperty("version", out JsonElement versionElem) && versionElem.ValueKind == JsonValueKind.Array)
                                        {
                                            versionStr = string.Join(".", versionElem.EnumerateArray().Select(v => v.GetInt32().ToString()));
                                        }
                                        // Prepare ListViewItem (not added to UI yet)
                                        var item = new ListViewItem(uuid);
                                        item.SubItems.Add(dirName);
                                        item.SubItems.Add(name);
                                        item.SubItems.Add(versionStr);
                                        item.SubItems.Add(description);
                                        items.Add(item);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                if (txtLog != null)
                                {
                                    Log(txtLog, $"Error reading {manifestPath}. {ex.ToString()}", LogLevel.ERROR);
                                }
                            }
                        }
                    }
                    return items;
                });

                // Update UI on the main thread
                lstAvailableMods.Items.AddRange(modItems.ToArray());
                if (txtLog != null)
                {
                    Log(txtLog, $"Refreshing {packsType} packs [DONE], refreshing installed packs", LogLevel.INFO);
                }

                try
                {
                    // Ensure world_packs.json exists
                    if (!File.Exists(worldPacksPath))
                    {
                        File.WriteAllText(worldPacksPath, "[]");
                    }
                }
                catch (IOException eIO)
                {
                    if (btnRefresh != null)
                    {
                        btnRefresh.Enabled = true;
                        btnRefresh.Text = "&Refresh";
                    }
                    if (txtLog != null)
                    {
                        Log(txtLog, $"'{worldPacksPath}' does not exist, nor could it be created\n{eIO}", LogLevel.ERROR);
                    }
                    MessageBox.Show($"'{worldPacksPath}' does not exist, nor could it be created\n{eIO}", "File permissions error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Populate lstInstalledMods from world_packs.json
                lstInstalledMods.Items.Clear();
                try
                {
                    string json = Regex.Replace(
                        File.ReadAllText(worldPacksPath),
                        @"^\s*(\\|//).*?$",
                        "",
                        RegexOptions.Multiline);

                    using (JsonDocument doc = JsonDocument.Parse(json))
                    {
                        if (doc.RootElement.ValueKind == JsonValueKind.Array)
                        {
                            foreach (var element in doc.RootElement.EnumerateArray())
                            {
                                if (element.TryGetProperty("pack_id", out JsonElement packIdElem) &&
                                    element.TryGetProperty("version", out JsonElement versionElem) &&
                                    versionElem.ValueKind == JsonValueKind.Array)
                                {
                                    string packId = packIdElem.GetString() ?? "";
                                    string versionStr = string.Join(".", versionElem.EnumerateArray().Select(v => v.GetInt32().ToString()));
                                    var item = new ListViewItem(packId);

                                    var foundItem = modItems.FirstOrDefault(i => i.Text == packId);
                                    string dirName = "Not found";
                                    string modName = "Not found";
                                    string description = "Not found";
                                    if (foundItem != null)
                                    {
                                        dirName = foundItem.SubItems[1].Text;
                                        modName = foundItem.SubItems[2].Text;
                                        description = foundItem.SubItems[4].Text;
                                    }
                                    item.SubItems.Add(dirName);
                                    item.SubItems.Add(modName);
                                    item.SubItems.Add(versionStr);
                                    item.SubItems.Add(description);
                                    lstInstalledMods.Items.Add(item);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (txtLog != null)
                    {
                        Log(txtLog, $"Error reading {worldPacksPath}. {ex.ToString()}", LogLevel.ERROR);
                    }
                }
                finally
                {
                    if (btnRefresh != null)
                    {
                        btnRefresh.Enabled = true;
                        btnRefresh.Text = "&Refresh";
                    }
                    if (txtLog != null)
                    {
                        Log(txtLog, $"Refreshing {packsType} packs [DONE]", LogLevel.INFO);
                    }
                }
            }
            else
            {
                if (btnRefresh != null)
                {
                    btnRefresh.Enabled = true;
                    btnRefresh.Text = "&Refresh";
                }
                tabCtrlMinecraft.SelectedTab = tabDirectories;
                if (txtLog != null)
                {
                    Log(txtLog, $"{packsType.First().ToString().ToUpper() + packsType.Substring(1)} packs directory does not exist.", LogLevel.ERROR);
                }   
                MessageBox.Show($"{packsType.First().ToString().ToUpper() + packsType.Substring(1)} packs directory does not exist.", "Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPacks.Focus();
            }
        }

        public static void ActivateSelectedPacks(ListView lstAvailableMods, ListView lstInstalledMods, TextBox txtLog)
        {
            foreach (ListViewItem item in lstAvailableMods.SelectedItems)
            {
                var foundItem = lstInstalledMods.FindItemWithText(item.Text);
                if (foundItem == null)
                {
                    ListViewItem? newItem = item.Clone() as ListViewItem;
                    if (newItem != null)
                    {
                        lstInstalledMods.Items.Add(newItem);
                        if (txtLog != null)
                        {
                            Log(txtLog, $"Added {item.Text} to activated packs.", LogLevel.INFO);
                        }
                    }
                    else
                    {
                        if (txtLog != null)
                        {
                            Log(txtLog, $"Failed to clone ListViewItem for {item.Text}.", LogLevel.ERROR);
                        }
                    }
                }
                else
                {
                    if (item.SubItems.Count > 4 && foundItem.SubItems.Count > 4)
                    {
                        foundItem.SubItems[1].Text = item.SubItems[1].Text;
                        foundItem.SubItems[2].Text = item.SubItems[2].Text;
                        foundItem.SubItems[3].Text = item.SubItems[3].Text;
                        foundItem.SubItems[4].Text = item.SubItems[4].Text;
                        if (txtLog != null)
                        {
                            Log(txtLog, $"Updated {item.Text} in activated packs.", LogLevel.INFO);
                        }
                    }
                    else
                    {
                        if (txtLog != null)
                        {
                            Log(txtLog, $"Item {item.Text} already exists in installed packs but couldn't be updated.", LogLevel.WARN);
                        }
                    }
                }
            }
            lstAvailableMods.Focus();
        }

        public static void DeactivateSelectedPacks(ListView lstInstalledMods, ListView lstAvailableMods, TextBox txtLog)
        {
            foreach (ListViewItem item in lstInstalledMods.SelectedItems)
            {
                lstInstalledMods.Items.Remove(item);
                if (txtLog != null)
                {
                    Log(txtLog, $"Removed {item.Text} from activated packs.", LogLevel.INFO);
                }
            }
            if (lstInstalledMods.Items.Count > 0)
            {
                lstInstalledMods.Items[lstInstalledMods.Items.Count - 1].Selected = true;
                lstAvailableMods.Focus();
            }
            else
            {
                lstAvailableMods.Focus();
            }
        }

        public static void SavePacks(ListView lstInstalledMods, string worldPacksPath, TextBox txtLog)
        {
            var packs = new List<object>();

            if (txtLog != null)
            {
                Log(txtLog, $"Building configuration to be saved", LogLevel.DEBUG);
            }

            foreach (ListViewItem item in lstInstalledMods.Items)
            {
                string _name = item.SubItems.Count > 3 ? item.SubItems[1].Text : "";
                string packId = item.Text;
                string versionStr = item.SubItems.Count > 3 ? item.SubItems[3].Text : "";
                int[] versionArr = versionStr.Split('.')
                    .Select(s => int.TryParse(s, out int v) ? v : 0)
                    .ToArray();

                packs.Add(new
                {
                    _name = _name,
                    pack_id = packId,
                    version = versionArr
                });
            }

            if (txtLog != null)
            {
                Log(txtLog, $"Converting configuration to JSON to be saved", LogLevel.DEBUG);
            }

            string json = JsonSerializer.Serialize(packs, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(worldPacksPath, json);
            if (txtLog != null)
            {
                Log(txtLog, $"Saved configuration to {worldPacksPath}", LogLevel.INFO);
            }
        }

        public static void MoveSelectedUp(ListView lstInstalledMods, TextBox txtLog)
        {
            var selectedIndices = lstInstalledMods.SelectedIndices.Cast<int>().OrderBy(i => i).ToList();
            if (selectedIndices.Count == 0 || selectedIndices[0] == 0)
                return;

            lstInstalledMods.BeginUpdate();
            try
            {
                foreach (int index in selectedIndices)
                {
                    if (index > 0)
                    {
                        if (txtLog != null)
                        {
                            Log(txtLog, $"Moving {lstInstalledMods.Items[index].Text} up", LogLevel.DEBUG);
                        }
                        var item = lstInstalledMods.Items[index];
                        var aboveItem = lstInstalledMods.Items[index - 1];

                        var itemClone = (ListViewItem)item.Clone();
                        var aboveClone = (ListViewItem)aboveItem.Clone();

                        lstInstalledMods.Items[index - 1] = itemClone;
                        lstInstalledMods.Items[index] = aboveClone;

                        itemClone.Selected = true;
                        aboveClone.Selected = false;
                    }
                }
            }
            catch (Exception ex)
            {
                if (txtLog != null)
                {
                    Log(txtLog, $"Error moving items: {ex.ToString()}", LogLevel.ERROR);
                }
            }
            finally
            {
                lstInstalledMods.EndUpdate();
            }
            lstInstalledMods.Focus();
        }

        public static void MoveSelectedDown(ListView lstInstalledMods, TextBox txtLog)
        {
            var selectedIndices = lstInstalledMods.SelectedIndices.Cast<int>().OrderByDescending(i => i).ToList();
            if (selectedIndices.Count == 0 || selectedIndices.Last() == lstInstalledMods.Items.Count - 1)
                return;

            lstInstalledMods.BeginUpdate();
            try
            {
                foreach (int index in selectedIndices)
                {
                    if (index < lstInstalledMods.Items.Count - 1)
                    {
                        if (txtLog != null)
                        {
                            Log(txtLog, $"Moving {lstInstalledMods.Items[index].Text} down", LogLevel.DEBUG);
                        }   
                        var item = lstInstalledMods.Items[index];
                        var belowItem = lstInstalledMods.Items[index + 1];

                        var itemClone = (ListViewItem)item.Clone();
                        var belowClone = (ListViewItem)belowItem.Clone();

                        lstInstalledMods.Items[index] = belowClone;
                        lstInstalledMods.Items[index + 1] = itemClone;

                        itemClone.Selected = true;
                        belowClone.Selected = false;
                    }
                }
            }
            catch (Exception ex)
            {
                if (txtLog != null)
                {
                    Log(txtLog, $"Error moving items: {ex.ToString()}", LogLevel.ERROR);
                }
            }
            finally
            {
                lstInstalledMods.EndUpdate();
            }
            lstInstalledMods.Focus();
        }
        public static void Log(TextBox txtLog, string message, LogLevel level = LogLevel.INFO)
        {
            if (level < 0 || txtLog == null) return;

            string prefix = level switch
            {
                LogLevel.DEBUG => "[DEBUG] ",
                LogLevel.INFO => "[INFO] ",
                LogLevel.WARN => "[WARN] ",
                LogLevel.ERROR => "[ERROR] ",
                _ => $"[LEVEL {level}] "
            };

            string[] lines = message.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new Action(() =>
                {
                    foreach (var line in lines)
                    {
                        txtLog.AppendText($"{prefix}{line}{Environment.NewLine}");
                    }
                }));
            }
            else
            {
                foreach (var line in lines)
                {
                    txtLog.AppendText($"{prefix}{line}{Environment.NewLine}");
                }
            }
        }

    }
}
