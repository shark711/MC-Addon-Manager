//using Microsoft.VisualBasic;
//using System;
//using System.Linq.Expressions;
//using System.Text.Json;
//using System.Text.RegularExpressions;
//using MC_Addon_Manager.PackManagerHelper;

namespace MC_Addon_Manager
{
    
    public partial class frmMain : Form
    {
        private string[] CommandLineArgs = Environment.GetCommandLineArgs();
        private ListViewColumnSorter lvwBehaviorColumnSorter, lvwResourceColumnSorter;
        public frmMain()
        {
            InitializeComponent();
            lvwBehaviorColumnSorter = new ListViewColumnSorter();
            lvwResourceColumnSorter = new ListViewColumnSorter();
            this.lstAvailableBehaviorMods.ListViewItemSorter = lvwBehaviorColumnSorter;
            this.lstAvailableResourceMods.ListViewItemSorter = lvwResourceColumnSorter;
            // Set the default directory for Minecraft Bedrock (Windows 10/11)
            txtWorldDirectory.Text = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Packages",
                "Microsoft.MinecraftUWP_8wekyb3d8bbwe",
                "LocalState",
                "games",
                "com.mojang",
                "minecraftWorlds"
            );
            PackManagerHelper.Log(txtLog, "MC Addon Manager started.", LogLevel.DEBUG);
        }

        private void btnBrowseWorldDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialogWorldDirectory.InitialDirectory = txtWorldDirectory.Text;
            folderBrowserDialogWorldDirectory.ShowDialog();
            String selectedPath = folderBrowserDialogWorldDirectory.SelectedPath;
            if (selectedPath != "")
            {
                if (selectedPath != txtWorldDirectory.Text)
                {
                    PackManagerHelper.Log(txtLog, "Directory Changed, clearing lists. You need to refresh them to view packs", LogLevel.DEBUG);
                    lstAvailableBehaviorMods.Items.Clear();
                    lstAvailableResourceMods.Items.Clear();
                    lstInstalledBehavoirMods.Items.Clear();
                    lstInstalledResourceMods.Items.Clear();
                    txtWorldDirectory.Text = selectedPath;
                }
                // Check if level.dat exists in the selected directory
                string levelDatPath = Path.Combine(selectedPath, "level.dat");
                if (File.Exists(levelDatPath))
                {
                    chkBoxWorldDirectory.Checked = true;
                    PackManagerHelper.Log(txtLog, "World Directory: '" + selectedPath + "' selected.", LogLevel.INFO);
                    //MessageBox.Show("level.dat found in the selected directory.", "File Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string? parentDir = Directory.GetParent(selectedPath)?.FullName;
                    if (parentDir != null)
                    {
                        string? grandParentDir = Directory.GetParent(parentDir)?.FullName;
                        if (grandParentDir != null)
                        {
                            string behaviorPacks = Path.Combine(grandParentDir, "behavior_packs");
                            string resourcePacks = Path.Combine(grandParentDir, "resource_packs");
                            PackManagerHelper.Log(txtLog, "Trying to auto determine paths for behavior_packs or resource_packs.", LogLevel.DEBUG);
                            if (Directory.Exists(behaviorPacks))
                            {
                                txtBehaviorPacks.Text = behaviorPacks;
                                chkBoxBehaviorPacks.Checked = true;
                                PackManagerHelper.Log(txtLog, behaviorPacks + " seems like valid path, using it for behavior_packs.", LogLevel.DEBUG);
                            }
                            if (Directory.Exists(resourcePacks))
                            {
                                txtResourcePacks.Text = resourcePacks;
                                chkBoxResourcePacks.Checked = true;
                                PackManagerHelper.Log(txtLog, resourcePacks + " seems like valid path, using it for resource_packs.", LogLevel.DEBUG);
                            }
                        }
                        else
                        {
                            PackManagerHelper.Log(txtLog, "Grandparent directory is null. Cannot auto determine paths for behavior_packs or resource_packs.", LogLevel.DEBUG);
                        }
                    }
                    else
                    {
                        PackManagerHelper.Log(txtLog, "Parent directory is null. Cannot auto determine paths for behavior_packs or resource_packs.", LogLevel.DEBUG);
                    }
                }
            }
        }

        private void btnBrowseBehaviorPacks_Click(object sender, EventArgs e)
        {
            folderBrowserDialogBehaviorPacks.InitialDirectory = txtBehaviorPacks.Text;
            folderBrowserDialogBehaviorPacks.ShowDialog();
            String selectedPath = folderBrowserDialogBehaviorPacks.SelectedPath;
            if (selectedPath != "")
            {
                chkBoxBehaviorPacks.Checked = false;
                txtBehaviorPacks.Text = selectedPath;
                // Check if the selected directory is named "behavior_packs"
                if (Path.GetFileName(selectedPath.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)).Equals("behavior_packs", StringComparison.OrdinalIgnoreCase))
                {
                    chkBoxBehaviorPacks.Checked = true;
                    PackManagerHelper.Log(txtLog, "behavior_packs Directory: '" + selectedPath + "' selected.", LogLevel.INFO);
                }
                else
                {
                    MessageBox.Show("Please select a directory named 'behavior_packs'.", "Directory Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnBrowseResourcePacks_Click(object sender, EventArgs e)
        {
            folderBrowserDialogResourcePacks.InitialDirectory = txtResourcePacks.Text;
            folderBrowserDialogResourcePacks.ShowDialog();
            String selectedPath = folderBrowserDialogResourcePacks.SelectedPath;
            if (selectedPath != "")
            {
                chkBoxResourcePacks.Checked = false;
                // Check if the selected directory is named "resource_packs"
                txtResourcePacks.Text = selectedPath;
                if (Path.GetFileName(selectedPath.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)).Equals("resource_packs", StringComparison.OrdinalIgnoreCase))
                {
                    chkBoxResourcePacks.Checked = true;
                    PackManagerHelper.Log(txtLog, "resource_packs Directory: '" + selectedPath + "' selected.", LogLevel.INFO);
                }
                else
                {
                    MessageBox.Show("Please select a directory named 'resource_packs'.", "Directory Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void lstAvailableBehaviorMods_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            PackManagerHelper.Log(txtLog, "Sorting based on column " + e.Column.ToString(), LogLevel.DEBUG);
            if (e.Column == lvwBehaviorColumnSorter.SortColumn)
            {
                if (lvwBehaviorColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwBehaviorColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwBehaviorColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwBehaviorColumnSorter.SortColumn = e.Column;
                lvwBehaviorColumnSorter.Order = SortOrder.Ascending;
            }
            this.lstAvailableBehaviorMods.Sort();
        }

        private async void btnBehaviorPacksRefresh_Click(object sender, EventArgs e)
        {
            btnBehaviorPacksSave.Enabled = false;
            await PackManagerHelper.RefreshPacksAsync(
                txtBehaviorPacks.Text,
                Path.Combine(txtWorldDirectory.Text, "world_behavior_packs.json"),
                lstAvailableBehaviorMods,
                lstInstalledBehavoirMods,
                chkBoxBehaviorPacks,
                tabCtrlMinecraft,
                tabDirectories,
                txtBehaviorPacks,
                btnBehaviorPacksRefresh,
                "behavior",
                txtLog
            );
        }

        private void btnBehaviorPacksActivate_Click(object sender, EventArgs e)
        {
            PackManagerHelper.ActivateSelectedPacks(lstAvailableBehaviorMods, lstInstalledBehavoirMods, txtLog);
            btnBehaviorPacksSave.Enabled = true;
        }

        private void btnBehaviorPacksDeactivate_Click(object sender, EventArgs e)
        {
            PackManagerHelper.DeactivateSelectedPacks(lstInstalledBehavoirMods, lstAvailableBehaviorMods, txtLog);
            btnBehaviorPacksSave.Enabled = true;
        }

        private void btnBehaviorPacksSave_Click(object sender, EventArgs e)
        {
            PackManagerHelper.SavePacks(
                lstInstalledBehavoirMods,
                Path.Combine(txtWorldDirectory.Text, "world_behavior_packs.json"),
                txtLog
            );
            btnBehaviorPacksSave.Enabled = false;
        }

        private void btnBehaviorPacksMoveUp_Click(object sender, EventArgs e)
        {
            PackManagerHelper.MoveSelectedUp(lstInstalledBehavoirMods, txtLog);
            btnBehaviorPacksSave.Enabled = true;
        }

        private void btnBehaviorPacksMoveDown_Click(object sender, EventArgs e)
        {
            PackManagerHelper.MoveSelectedDown(lstInstalledBehavoirMods, txtLog);
            btnBehaviorPacksSave.Enabled = true;
        }

        private void lstAvailableResourceMods_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            PackManagerHelper.Log(txtLog, "Sorting based on column " + e.Column.ToString(), LogLevel.DEBUG);
            if (e.Column == lvwResourceColumnSorter.SortColumn)
            {
                if (lvwResourceColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwResourceColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwResourceColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwResourceColumnSorter.SortColumn = e.Column;
                lvwResourceColumnSorter.Order = SortOrder.Ascending;
            }
            this.lstAvailableResourceMods.Sort();
        }

        private async void btnResourcePacksRefresh_Click(object sender, EventArgs e)
        {
            btnResourcePacksSave.Enabled = false;
            await PackManagerHelper.RefreshPacksAsync(
                txtResourcePacks.Text,
                Path.Combine(txtWorldDirectory.Text, "world_resource_packs.json"),
                lstAvailableResourceMods,
                lstInstalledResourceMods,
                chkBoxResourcePacks,
                tabCtrlMinecraft,
                tabDirectories,
                txtResourcePacks,
                btnResourcePacksRefresh,
                "resource",
                txtLog
            );
        }

        private void btnResourcePacksActivate_Click(object sender, EventArgs e)
        {
            PackManagerHelper.ActivateSelectedPacks(lstAvailableResourceMods, lstInstalledResourceMods, txtLog);
            btnResourcePacksSave.Enabled = true;
        }

        private void btnResourcePacksDeactivate_Click(object sender, EventArgs e)
        {
            PackManagerHelper.DeactivateSelectedPacks(lstInstalledResourceMods, lstAvailableResourceMods, txtLog);
            btnResourcePacksSave.Enabled = true;
        }

        private void btnResourcePacksSave_Click(object sender, EventArgs e)
        {
            btnResourcePacksSave.Enabled = false;
            PackManagerHelper.SavePacks(
                lstInstalledResourceMods,
                Path.Combine(txtWorldDirectory.Text, "world_resource_packs.json"),
                txtLog
            );
        }

        private void btnResourcePacksMoveUp_Click(object sender, EventArgs e)
        {
            PackManagerHelper.MoveSelectedUp(lstInstalledResourceMods, txtLog);
            btnResourcePacksSave.Enabled = true;
        }

        private void btnResourcePacksMoveDown_Click(object sender, EventArgs e)
        {
            PackManagerHelper.MoveSelectedDown(lstInstalledResourceMods, txtLog);
            btnResourcePacksSave.Enabled = true;
        }

        private void lstInstalledBehavoirMods_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                foreach (ListViewItem item in lstAvailableBehaviorMods.Items)
                {
                    item.Selected = false;
                }
                foreach (ListViewItem item in lstAvailableBehaviorMods.Items)
                {
                    if (item.Text == e.Item?.Text)
                    {
                        item.Selected = true;
                        break;
                    }
                }
            }
        }

        private void lstInstalledResourceMods_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                foreach (ListViewItem item in lstAvailableResourceMods.Items)
                {
                    item.Selected = false;
                }
                foreach (ListViewItem item in lstAvailableResourceMods.Items)
                {
                    if (item.Text == e.Item?.Text)
                    {
                        item.Selected = true;
                        break;
                    }
                }
            }
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            // Get the last line and set that to the value of toolStripStatusLabelLog
            string[] lines = txtLog.Lines;
            if (lines.Length > 0)
            {
                String lastLine = lines[^2];
                int maxLength = 100;
                if (lastLine.Length > maxLength)
                    lastLine = lastLine.Substring(0, maxLength) + "...";
                toolStripStatuslbl.Text = lastLine;
            }
            else
            {
                toolStripStatuslbl.Text = "Idle";
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (string CommandLineArg in CommandLineArgs)
            {
                /*if (CommandLineArg.Contains("worlddir="))
                {
                    String worldDir = CommandLineArg.Split('=')[1];
                    if (Directory.Exists(worldDir))
                    {
                        txtWorldDirectory.Text = worldDir;
                        chkBoxWorldDirectory.Checked = true;
                        PackManagerHelper.Log(txtLog, "World Directory: '" + worldDir + "' selected.", LogLevel.INFO);
                    }
                    else
                    {
                        MessageBox.Show("Invalid world directory specified in command line arguments.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }*/
                PackManagerHelper.Log(txtLog, "Command Line Argument: " + CommandLineArg, LogLevel.DEBUG);
            }
        }
    }
}
