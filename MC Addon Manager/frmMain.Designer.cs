namespace MC_Addon_Manager
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            folderBrowserDialogWorldDirectory = new FolderBrowserDialog();
            btnBrowseWorldDirectory = new Button();
            tabCtrlMinecraft = new TabControl();
            tabDirectories = new TabPage();
            chkBoxResourcePacks = new CheckBox();
            chkBoxBehaviorPacks = new CheckBox();
            chkBoxWorldDirectory = new CheckBox();
            btnBrowseResourcePacks = new Button();
            lblResourcePacks = new Label();
            txtResourcePacks = new TextBox();
            btnBrowseBehaviorPacks = new Button();
            lblBehaviorPacks = new Label();
            txtBehaviorPacks = new TextBox();
            txtWorldDirectory = new TextBox();
            lblWorldDirectory = new Label();
            tabBehaviorPacks = new TabPage();
            btnBehaviorPacksMoveDown = new Button();
            btnBehaviorPacksMoveUp = new Button();
            btnBehaviorPacksSave = new Button();
            btnBehaviorPacksDeactivate = new Button();
            btnBehaviorPacksActivate = new Button();
            lblBehaviorPacksActive = new Label();
            lblBehaviorPacksAvailable = new Label();
            lstInstalledBehavoirMods = new ListView();
            colBPInstalled_UUID = new ColumnHeader();
            colBPInstalled_Dir = new ColumnHeader();
            colBPInstalled_Name = new ColumnHeader();
            colBPInstalled_Version = new ColumnHeader();
            colBPInstalled_Desc = new ColumnHeader();
            btnBehaviorPacksRefresh = new Button();
            lstAvailableBehaviorMods = new ListView();
            colBPAvail_UUID = new ColumnHeader();
            colBPAvail_Dir = new ColumnHeader();
            colBPAvail_ModName = new ColumnHeader();
            colBPAvail_Version = new ColumnHeader();
            colBPAvail_Desc = new ColumnHeader();
            tabResourcePacks = new TabPage();
            lblResourcePacksActive = new Label();
            lblResourcePacksAvailable = new Label();
            btnResourcePacksMoveDown = new Button();
            btnResourcePacksMoveUp = new Button();
            btnResourcePacksSave = new Button();
            btnResourcePacksDeactivate = new Button();
            btnResourcePacksActivate = new Button();
            btnResourcePacksRefresh = new Button();
            lstInstalledResourceMods = new ListView();
            colRPInstalled_UUID = new ColumnHeader();
            colRPInstalled_Dir = new ColumnHeader();
            colRPInstalled_Name = new ColumnHeader();
            colRPInstalled_Version = new ColumnHeader();
            colRPInstalled_Desc = new ColumnHeader();
            lstAvailableResourceMods = new ListView();
            colRPAvail_UUID = new ColumnHeader();
            colRPAvail_Dir = new ColumnHeader();
            colRPAvail_ModName = new ColumnHeader();
            colRPAvail_Version = new ColumnHeader();
            colRPAvail_Desc = new ColumnHeader();
            tabLogs = new TabPage();
            txtLog = new TextBox();
            folderBrowserDialogBehaviorPacks = new FolderBrowserDialog();
            folderBrowserDialogResourcePacks = new FolderBrowserDialog();
            statusStrip1 = new StatusStrip();
            toolStripStatuslbl = new ToolStripStatusLabel();
            tabCtrlMinecraft.SuspendLayout();
            tabDirectories.SuspendLayout();
            tabBehaviorPacks.SuspendLayout();
            tabResourcePacks.SuspendLayout();
            tabLogs.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBrowseWorldDirectory
            // 
            btnBrowseWorldDirectory.Location = new Point(792, 32);
            btnBrowseWorldDirectory.Name = "btnBrowseWorldDirectory";
            btnBrowseWorldDirectory.Size = new Size(75, 23);
            btnBrowseWorldDirectory.TabIndex = 0;
            btnBrowseWorldDirectory.Text = "Bro&wse";
            btnBrowseWorldDirectory.UseVisualStyleBackColor = true;
            btnBrowseWorldDirectory.Click += btnBrowseWorldDirectory_Click;
            // 
            // tabCtrlMinecraft
            // 
            tabCtrlMinecraft.Controls.Add(tabDirectories);
            tabCtrlMinecraft.Controls.Add(tabBehaviorPacks);
            tabCtrlMinecraft.Controls.Add(tabResourcePacks);
            tabCtrlMinecraft.Controls.Add(tabLogs);
            tabCtrlMinecraft.Location = new Point(0, 24);
            tabCtrlMinecraft.Name = "tabCtrlMinecraft";
            tabCtrlMinecraft.SelectedIndex = 0;
            tabCtrlMinecraft.Size = new Size(904, 792);
            tabCtrlMinecraft.TabIndex = 1;
            // 
            // tabDirectories
            // 
            tabDirectories.Controls.Add(chkBoxResourcePacks);
            tabDirectories.Controls.Add(chkBoxBehaviorPacks);
            tabDirectories.Controls.Add(chkBoxWorldDirectory);
            tabDirectories.Controls.Add(btnBrowseResourcePacks);
            tabDirectories.Controls.Add(lblResourcePacks);
            tabDirectories.Controls.Add(txtResourcePacks);
            tabDirectories.Controls.Add(btnBrowseBehaviorPacks);
            tabDirectories.Controls.Add(lblBehaviorPacks);
            tabDirectories.Controls.Add(txtBehaviorPacks);
            tabDirectories.Controls.Add(txtWorldDirectory);
            tabDirectories.Controls.Add(lblWorldDirectory);
            tabDirectories.Controls.Add(btnBrowseWorldDirectory);
            tabDirectories.Location = new Point(4, 24);
            tabDirectories.Name = "tabDirectories";
            tabDirectories.Padding = new Padding(3);
            tabDirectories.Size = new Size(896, 764);
            tabDirectories.TabIndex = 0;
            tabDirectories.Text = "Directories";
            tabDirectories.UseVisualStyleBackColor = true;
            // 
            // chkBoxResourcePacks
            // 
            chkBoxResourcePacks.AutoCheck = false;
            chkBoxResourcePacks.AutoSize = true;
            chkBoxResourcePacks.Location = new Point(872, 144);
            chkBoxResourcePacks.Name = "chkBoxResourcePacks";
            chkBoxResourcePacks.Padding = new Padding(0, 4, 0, 0);
            chkBoxResourcePacks.Size = new Size(15, 18);
            chkBoxResourcePacks.TabIndex = 11;
            chkBoxResourcePacks.UseVisualStyleBackColor = true;
            // 
            // chkBoxBehaviorPacks
            // 
            chkBoxBehaviorPacks.AutoCheck = false;
            chkBoxBehaviorPacks.AutoSize = true;
            chkBoxBehaviorPacks.Location = new Point(872, 88);
            chkBoxBehaviorPacks.Name = "chkBoxBehaviorPacks";
            chkBoxBehaviorPacks.Padding = new Padding(0, 4, 0, 0);
            chkBoxBehaviorPacks.Size = new Size(15, 18);
            chkBoxBehaviorPacks.TabIndex = 10;
            chkBoxBehaviorPacks.UseVisualStyleBackColor = true;
            // 
            // chkBoxWorldDirectory
            // 
            chkBoxWorldDirectory.AutoCheck = false;
            chkBoxWorldDirectory.AutoSize = true;
            chkBoxWorldDirectory.Location = new Point(872, 32);
            chkBoxWorldDirectory.Name = "chkBoxWorldDirectory";
            chkBoxWorldDirectory.Padding = new Padding(0, 4, 0, 0);
            chkBoxWorldDirectory.Size = new Size(15, 18);
            chkBoxWorldDirectory.TabIndex = 9;
            chkBoxWorldDirectory.UseVisualStyleBackColor = true;
            // 
            // btnBrowseResourcePacks
            // 
            btnBrowseResourcePacks.Location = new Point(792, 144);
            btnBrowseResourcePacks.Name = "btnBrowseResourcePacks";
            btnBrowseResourcePacks.Size = new Size(75, 23);
            btnBrowseResourcePacks.TabIndex = 8;
            btnBrowseResourcePacks.Text = "B&rowse";
            btnBrowseResourcePacks.UseVisualStyleBackColor = true;
            btnBrowseResourcePacks.Click += btnBrowseResourcePacks_Click;
            // 
            // lblResourcePacks
            // 
            lblResourcePacks.AutoSize = true;
            lblResourcePacks.Location = new Point(8, 128);
            lblResourcePacks.Name = "lblResourcePacks";
            lblResourcePacks.Size = new Size(132, 15);
            lblResourcePacks.TabIndex = 7;
            lblResourcePacks.Text = "Behavior Pack Directory";
            // 
            // txtResourcePacks
            // 
            txtResourcePacks.Location = new Point(8, 144);
            txtResourcePacks.Name = "txtResourcePacks";
            txtResourcePacks.ReadOnly = true;
            txtResourcePacks.Size = new Size(776, 23);
            txtResourcePacks.TabIndex = 6;
            txtResourcePacks.Text = "C:\\";
            txtResourcePacks.WordWrap = false;
            // 
            // btnBrowseBehaviorPacks
            // 
            btnBrowseBehaviorPacks.Location = new Point(792, 88);
            btnBrowseBehaviorPacks.Name = "btnBrowseBehaviorPacks";
            btnBrowseBehaviorPacks.Size = new Size(75, 23);
            btnBrowseBehaviorPacks.TabIndex = 5;
            btnBrowseBehaviorPacks.Text = "&Browse";
            btnBrowseBehaviorPacks.UseVisualStyleBackColor = true;
            btnBrowseBehaviorPacks.Click += btnBrowseBehaviorPacks_Click;
            // 
            // lblBehaviorPacks
            // 
            lblBehaviorPacks.AutoSize = true;
            lblBehaviorPacks.Location = new Point(8, 72);
            lblBehaviorPacks.Name = "lblBehaviorPacks";
            lblBehaviorPacks.Size = new Size(132, 15);
            lblBehaviorPacks.TabIndex = 4;
            lblBehaviorPacks.Text = "Behavior Pack Directory";
            // 
            // txtBehaviorPacks
            // 
            txtBehaviorPacks.Location = new Point(8, 88);
            txtBehaviorPacks.Name = "txtBehaviorPacks";
            txtBehaviorPacks.ReadOnly = true;
            txtBehaviorPacks.Size = new Size(776, 23);
            txtBehaviorPacks.TabIndex = 3;
            txtBehaviorPacks.Text = "C:\\";
            txtBehaviorPacks.WordWrap = false;
            // 
            // txtWorldDirectory
            // 
            txtWorldDirectory.Location = new Point(8, 32);
            txtWorldDirectory.Name = "txtWorldDirectory";
            txtWorldDirectory.ReadOnly = true;
            txtWorldDirectory.Size = new Size(776, 23);
            txtWorldDirectory.TabIndex = 2;
            txtWorldDirectory.Text = "\\\\10.0.0.8\\Configuration\\Crafty\\servers\\dce66e19-a078-4f1f-84cc-c327aac02030\\worlds\\Roets family server";
            txtWorldDirectory.WordWrap = false;
            // 
            // lblWorldDirectory
            // 
            lblWorldDirectory.AutoSize = true;
            lblWorldDirectory.Location = new Point(8, 16);
            lblWorldDirectory.Name = "lblWorldDirectory";
            lblWorldDirectory.Size = new Size(90, 15);
            lblWorldDirectory.TabIndex = 1;
            lblWorldDirectory.Text = "World Directory";
            // 
            // tabBehaviorPacks
            // 
            tabBehaviorPacks.Controls.Add(btnBehaviorPacksMoveDown);
            tabBehaviorPacks.Controls.Add(btnBehaviorPacksMoveUp);
            tabBehaviorPacks.Controls.Add(btnBehaviorPacksSave);
            tabBehaviorPacks.Controls.Add(btnBehaviorPacksDeactivate);
            tabBehaviorPacks.Controls.Add(btnBehaviorPacksActivate);
            tabBehaviorPacks.Controls.Add(lblBehaviorPacksActive);
            tabBehaviorPacks.Controls.Add(lblBehaviorPacksAvailable);
            tabBehaviorPacks.Controls.Add(lstInstalledBehavoirMods);
            tabBehaviorPacks.Controls.Add(btnBehaviorPacksRefresh);
            tabBehaviorPacks.Controls.Add(lstAvailableBehaviorMods);
            tabBehaviorPacks.Location = new Point(4, 24);
            tabBehaviorPacks.Name = "tabBehaviorPacks";
            tabBehaviorPacks.Size = new Size(896, 764);
            tabBehaviorPacks.TabIndex = 2;
            tabBehaviorPacks.Text = "Behavior Packs";
            tabBehaviorPacks.UseVisualStyleBackColor = true;
            // 
            // btnBehaviorPacksMoveDown
            // 
            btnBehaviorPacksMoveDown.Location = new Point(280, 736);
            btnBehaviorPacksMoveDown.Name = "btnBehaviorPacksMoveDown";
            btnBehaviorPacksMoveDown.Size = new Size(128, 23);
            btnBehaviorPacksMoveDown.TabIndex = 10;
            btnBehaviorPacksMoveDown.Text = "Move Selected Down";
            btnBehaviorPacksMoveDown.UseVisualStyleBackColor = true;
            btnBehaviorPacksMoveDown.Click += btnBehaviorPacksMoveDown_Click;
            // 
            // btnBehaviorPacksMoveUp
            // 
            btnBehaviorPacksMoveUp.Location = new Point(144, 736);
            btnBehaviorPacksMoveUp.Name = "btnBehaviorPacksMoveUp";
            btnBehaviorPacksMoveUp.Size = new Size(128, 23);
            btnBehaviorPacksMoveUp.TabIndex = 9;
            btnBehaviorPacksMoveUp.Text = "Move Selected Up";
            btnBehaviorPacksMoveUp.UseVisualStyleBackColor = true;
            btnBehaviorPacksMoveUp.Click += btnBehaviorPacksMoveUp_Click;
            // 
            // btnBehaviorPacksSave
            // 
            btnBehaviorPacksSave.Enabled = false;
            btnBehaviorPacksSave.Location = new Point(760, 736);
            btnBehaviorPacksSave.Name = "btnBehaviorPacksSave";
            btnBehaviorPacksSave.Size = new Size(128, 23);
            btnBehaviorPacksSave.TabIndex = 8;
            btnBehaviorPacksSave.Text = "&Save Changes";
            btnBehaviorPacksSave.UseVisualStyleBackColor = true;
            btnBehaviorPacksSave.Click += btnBehaviorPacksSave_Click;
            // 
            // btnBehaviorPacksDeactivate
            // 
            btnBehaviorPacksDeactivate.Location = new Point(8, 736);
            btnBehaviorPacksDeactivate.Name = "btnBehaviorPacksDeactivate";
            btnBehaviorPacksDeactivate.Size = new Size(128, 23);
            btnBehaviorPacksDeactivate.TabIndex = 7;
            btnBehaviorPacksDeactivate.Text = "&Deactivate Selected";
            btnBehaviorPacksDeactivate.UseVisualStyleBackColor = true;
            btnBehaviorPacksDeactivate.Click += btnBehaviorPacksDeactivate_Click;
            // 
            // btnBehaviorPacksActivate
            // 
            btnBehaviorPacksActivate.Location = new Point(8, 352);
            btnBehaviorPacksActivate.Name = "btnBehaviorPacksActivate";
            btnBehaviorPacksActivate.Size = new Size(128, 23);
            btnBehaviorPacksActivate.TabIndex = 6;
            btnBehaviorPacksActivate.Text = "&Activate Selected";
            btnBehaviorPacksActivate.UseVisualStyleBackColor = true;
            btnBehaviorPacksActivate.Click += btnBehaviorPacksActivate_Click;
            // 
            // lblBehaviorPacksActive
            // 
            lblBehaviorPacksActive.AutoSize = true;
            lblBehaviorPacksActive.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBehaviorPacksActive.Location = new Point(8, 392);
            lblBehaviorPacksActive.Name = "lblBehaviorPacksActive";
            lblBehaviorPacksActive.Size = new Size(177, 21);
            lblBehaviorPacksActive.TabIndex = 5;
            lblBehaviorPacksActive.Text = "Active Behavior Packs";
            // 
            // lblBehaviorPacksAvailable
            // 
            lblBehaviorPacksAvailable.AutoSize = true;
            lblBehaviorPacksAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBehaviorPacksAvailable.Location = new Point(8, 8);
            lblBehaviorPacksAvailable.Name = "lblBehaviorPacksAvailable";
            lblBehaviorPacksAvailable.RightToLeft = RightToLeft.Yes;
            lblBehaviorPacksAvailable.Size = new Size(195, 21);
            lblBehaviorPacksAvailable.TabIndex = 4;
            lblBehaviorPacksAvailable.Text = "Installed Behavior Packs";
            // 
            // lstInstalledBehavoirMods
            // 
            lstInstalledBehavoirMods.Columns.AddRange(new ColumnHeader[] { colBPInstalled_UUID, colBPInstalled_Dir, colBPInstalled_Name, colBPInstalled_Version, colBPInstalled_Desc });
            lstInstalledBehavoirMods.FullRowSelect = true;
            lstInstalledBehavoirMods.Location = new Point(8, 424);
            lstInstalledBehavoirMods.Name = "lstInstalledBehavoirMods";
            lstInstalledBehavoirMods.Size = new Size(880, 304);
            lstInstalledBehavoirMods.TabIndex = 3;
            lstInstalledBehavoirMods.UseCompatibleStateImageBehavior = false;
            lstInstalledBehavoirMods.View = View.Details;
            lstInstalledBehavoirMods.ItemSelectionChanged += lstInstalledBehavoirMods_ItemSelectionChanged;
            // 
            // colBPInstalled_UUID
            // 
            colBPInstalled_UUID.Text = "UUID";
            colBPInstalled_UUID.Width = 0;
            // 
            // colBPInstalled_Dir
            // 
            colBPInstalled_Dir.Text = "Folder Name";
            colBPInstalled_Dir.Width = 120;
            // 
            // colBPInstalled_Name
            // 
            colBPInstalled_Name.Text = "Mod Name";
            colBPInstalled_Name.Width = 200;
            // 
            // colBPInstalled_Version
            // 
            colBPInstalled_Version.Text = "Version";
            // 
            // colBPInstalled_Desc
            // 
            colBPInstalled_Desc.Text = "Description";
            colBPInstalled_Desc.Width = 480;
            // 
            // btnBehaviorPacksRefresh
            // 
            btnBehaviorPacksRefresh.Location = new Point(760, 8);
            btnBehaviorPacksRefresh.Name = "btnBehaviorPacksRefresh";
            btnBehaviorPacksRefresh.Size = new Size(128, 23);
            btnBehaviorPacksRefresh.TabIndex = 2;
            btnBehaviorPacksRefresh.Text = "&Refresh";
            btnBehaviorPacksRefresh.UseVisualStyleBackColor = true;
            btnBehaviorPacksRefresh.Click += btnBehaviorPacksRefresh_Click;
            // 
            // lstAvailableBehaviorMods
            // 
            lstAvailableBehaviorMods.Columns.AddRange(new ColumnHeader[] { colBPAvail_UUID, colBPAvail_Dir, colBPAvail_ModName, colBPAvail_Version, colBPAvail_Desc });
            lstAvailableBehaviorMods.FullRowSelect = true;
            lstAvailableBehaviorMods.Location = new Point(8, 40);
            lstAvailableBehaviorMods.Name = "lstAvailableBehaviorMods";
            lstAvailableBehaviorMods.Size = new Size(880, 304);
            lstAvailableBehaviorMods.TabIndex = 1;
            lstAvailableBehaviorMods.UseCompatibleStateImageBehavior = false;
            lstAvailableBehaviorMods.View = View.Details;
            lstAvailableBehaviorMods.ColumnClick += lstAvailableBehaviorMods_ColumnClick;
            // 
            // colBPAvail_UUID
            // 
            colBPAvail_UUID.Text = "UUID";
            colBPAvail_UUID.Width = 0;
            // 
            // colBPAvail_Dir
            // 
            colBPAvail_Dir.Text = "Folder Name";
            colBPAvail_Dir.Width = 120;
            // 
            // colBPAvail_ModName
            // 
            colBPAvail_ModName.Text = "Mod Name";
            colBPAvail_ModName.Width = 200;
            // 
            // colBPAvail_Version
            // 
            colBPAvail_Version.Text = "Version";
            // 
            // colBPAvail_Desc
            // 
            colBPAvail_Desc.Text = "Description";
            colBPAvail_Desc.Width = 480;
            // 
            // tabResourcePacks
            // 
            tabResourcePacks.Controls.Add(lblResourcePacksActive);
            tabResourcePacks.Controls.Add(lblResourcePacksAvailable);
            tabResourcePacks.Controls.Add(btnResourcePacksMoveDown);
            tabResourcePacks.Controls.Add(btnResourcePacksMoveUp);
            tabResourcePacks.Controls.Add(btnResourcePacksSave);
            tabResourcePacks.Controls.Add(btnResourcePacksDeactivate);
            tabResourcePacks.Controls.Add(btnResourcePacksActivate);
            tabResourcePacks.Controls.Add(btnResourcePacksRefresh);
            tabResourcePacks.Controls.Add(lstInstalledResourceMods);
            tabResourcePacks.Controls.Add(lstAvailableResourceMods);
            tabResourcePacks.Location = new Point(4, 24);
            tabResourcePacks.Name = "tabResourcePacks";
            tabResourcePacks.Padding = new Padding(3);
            tabResourcePacks.Size = new Size(896, 764);
            tabResourcePacks.TabIndex = 1;
            tabResourcePacks.Text = "Resource Packs";
            tabResourcePacks.UseVisualStyleBackColor = true;
            // 
            // lblResourcePacksActive
            // 
            lblResourcePacksActive.AutoSize = true;
            lblResourcePacksActive.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResourcePacksActive.Location = new Point(8, 392);
            lblResourcePacksActive.Name = "lblResourcePacksActive";
            lblResourcePacksActive.Size = new Size(178, 21);
            lblResourcePacksActive.TabIndex = 9;
            lblResourcePacksActive.Text = "Active Resource Packs";
            // 
            // lblResourcePacksAvailable
            // 
            lblResourcePacksAvailable.AutoSize = true;
            lblResourcePacksAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResourcePacksAvailable.Location = new Point(8, 8);
            lblResourcePacksAvailable.Name = "lblResourcePacksAvailable";
            lblResourcePacksAvailable.Size = new Size(196, 21);
            lblResourcePacksAvailable.TabIndex = 8;
            lblResourcePacksAvailable.Text = "Installed Resource Packs";
            // 
            // btnResourcePacksMoveDown
            // 
            btnResourcePacksMoveDown.Location = new Point(280, 736);
            btnResourcePacksMoveDown.Name = "btnResourcePacksMoveDown";
            btnResourcePacksMoveDown.Size = new Size(128, 23);
            btnResourcePacksMoveDown.TabIndex = 7;
            btnResourcePacksMoveDown.Text = "Move Selected Down";
            btnResourcePacksMoveDown.UseVisualStyleBackColor = true;
            btnResourcePacksMoveDown.Click += btnResourcePacksMoveDown_Click;
            // 
            // btnResourcePacksMoveUp
            // 
            btnResourcePacksMoveUp.Location = new Point(144, 736);
            btnResourcePacksMoveUp.Name = "btnResourcePacksMoveUp";
            btnResourcePacksMoveUp.Size = new Size(128, 23);
            btnResourcePacksMoveUp.TabIndex = 6;
            btnResourcePacksMoveUp.Text = "Move Selected Up";
            btnResourcePacksMoveUp.UseVisualStyleBackColor = true;
            btnResourcePacksMoveUp.Click += btnResourcePacksMoveUp_Click;
            // 
            // btnResourcePacksSave
            // 
            btnResourcePacksSave.Enabled = false;
            btnResourcePacksSave.Location = new Point(760, 736);
            btnResourcePacksSave.Name = "btnResourcePacksSave";
            btnResourcePacksSave.Size = new Size(128, 23);
            btnResourcePacksSave.TabIndex = 5;
            btnResourcePacksSave.Text = "&Save Changes";
            btnResourcePacksSave.UseVisualStyleBackColor = true;
            btnResourcePacksSave.Click += btnResourcePacksSave_Click;
            // 
            // btnResourcePacksDeactivate
            // 
            btnResourcePacksDeactivate.Location = new Point(8, 736);
            btnResourcePacksDeactivate.Name = "btnResourcePacksDeactivate";
            btnResourcePacksDeactivate.Size = new Size(128, 23);
            btnResourcePacksDeactivate.TabIndex = 4;
            btnResourcePacksDeactivate.Text = "&Deactivate Selected";
            btnResourcePacksDeactivate.UseVisualStyleBackColor = true;
            btnResourcePacksDeactivate.Click += btnResourcePacksDeactivate_Click;
            // 
            // btnResourcePacksActivate
            // 
            btnResourcePacksActivate.Location = new Point(8, 352);
            btnResourcePacksActivate.Name = "btnResourcePacksActivate";
            btnResourcePacksActivate.Size = new Size(128, 24);
            btnResourcePacksActivate.TabIndex = 3;
            btnResourcePacksActivate.Text = "&Activate Selected";
            btnResourcePacksActivate.UseVisualStyleBackColor = true;
            btnResourcePacksActivate.Click += btnResourcePacksActivate_Click;
            // 
            // btnResourcePacksRefresh
            // 
            btnResourcePacksRefresh.Location = new Point(760, 8);
            btnResourcePacksRefresh.Name = "btnResourcePacksRefresh";
            btnResourcePacksRefresh.Size = new Size(128, 23);
            btnResourcePacksRefresh.TabIndex = 2;
            btnResourcePacksRefresh.Text = "&Refresh";
            btnResourcePacksRefresh.UseVisualStyleBackColor = true;
            btnResourcePacksRefresh.Click += btnResourcePacksRefresh_Click;
            // 
            // lstInstalledResourceMods
            // 
            lstInstalledResourceMods.Columns.AddRange(new ColumnHeader[] { colRPInstalled_UUID, colRPInstalled_Dir, colRPInstalled_Name, colRPInstalled_Version, colRPInstalled_Desc });
            lstInstalledResourceMods.FullRowSelect = true;
            lstInstalledResourceMods.Location = new Point(8, 424);
            lstInstalledResourceMods.Name = "lstInstalledResourceMods";
            lstInstalledResourceMods.Size = new Size(880, 304);
            lstInstalledResourceMods.TabIndex = 1;
            lstInstalledResourceMods.UseCompatibleStateImageBehavior = false;
            lstInstalledResourceMods.View = View.Details;
            lstInstalledResourceMods.ItemSelectionChanged += lstInstalledResourceMods_ItemSelectionChanged;
            // 
            // colRPInstalled_UUID
            // 
            colRPInstalled_UUID.Text = "UUID";
            colRPInstalled_UUID.Width = 0;
            // 
            // colRPInstalled_Dir
            // 
            colRPInstalled_Dir.Text = "Folder Name";
            colRPInstalled_Dir.Width = 120;
            // 
            // colRPInstalled_Name
            // 
            colRPInstalled_Name.Text = "Mod Name";
            colRPInstalled_Name.Width = 200;
            // 
            // colRPInstalled_Version
            // 
            colRPInstalled_Version.Text = "Version";
            // 
            // colRPInstalled_Desc
            // 
            colRPInstalled_Desc.Text = "Description";
            colRPInstalled_Desc.Width = 480;
            // 
            // lstAvailableResourceMods
            // 
            lstAvailableResourceMods.Columns.AddRange(new ColumnHeader[] { colRPAvail_UUID, colRPAvail_Dir, colRPAvail_ModName, colRPAvail_Version, colRPAvail_Desc });
            lstAvailableResourceMods.FullRowSelect = true;
            lstAvailableResourceMods.Location = new Point(8, 40);
            lstAvailableResourceMods.Name = "lstAvailableResourceMods";
            lstAvailableResourceMods.Size = new Size(880, 304);
            lstAvailableResourceMods.TabIndex = 0;
            lstAvailableResourceMods.UseCompatibleStateImageBehavior = false;
            lstAvailableResourceMods.View = View.Details;
            lstAvailableResourceMods.ColumnClick += lstAvailableResourceMods_ColumnClick;
            // 
            // colRPAvail_UUID
            // 
            colRPAvail_UUID.Text = "UUID";
            colRPAvail_UUID.Width = 0;
            // 
            // colRPAvail_Dir
            // 
            colRPAvail_Dir.Text = "Folder Name";
            colRPAvail_Dir.Width = 120;
            // 
            // colRPAvail_ModName
            // 
            colRPAvail_ModName.Text = "Mod Name";
            colRPAvail_ModName.Width = 200;
            // 
            // colRPAvail_Version
            // 
            colRPAvail_Version.Text = "Version";
            // 
            // colRPAvail_Desc
            // 
            colRPAvail_Desc.Text = "Description";
            colRPAvail_Desc.Width = 480;
            // 
            // tabLogs
            // 
            tabLogs.Controls.Add(txtLog);
            tabLogs.Location = new Point(4, 24);
            tabLogs.Name = "tabLogs";
            tabLogs.Size = new Size(896, 764);
            tabLogs.TabIndex = 3;
            tabLogs.Text = "Logs";
            tabLogs.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            txtLog.CausesValidation = false;
            txtLog.Location = new Point(8, 8);
            txtLog.MaxLength = 0;
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ScrollBars = ScrollBars.Both;
            txtLog.Size = new Size(880, 752);
            txtLog.TabIndex = 0;
            txtLog.WordWrap = false;
            txtLog.TextChanged += txtLog_TextChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatuslbl });
            statusStrip1.Location = new Point(0, 814);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(904, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatuslbl
            // 
            toolStripStatuslbl.Name = "toolStripStatuslbl";
            toolStripStatuslbl.Size = new Size(62, 17);
            toolStripStatuslbl.Text = "Loading ...";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 836);
            Controls.Add(statusStrip1);
            Controls.Add(tabCtrlMinecraft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(920, 875);
            MinimumSize = new Size(920, 875);
            Name = "frmMain";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Minecraft Bedrock Mod Enabler";
            Load += frmMain_Load;
            tabCtrlMinecraft.ResumeLayout(false);
            tabDirectories.ResumeLayout(false);
            tabDirectories.PerformLayout();
            tabBehaviorPacks.ResumeLayout(false);
            tabBehaviorPacks.PerformLayout();
            tabResourcePacks.ResumeLayout(false);
            tabResourcePacks.PerformLayout();
            tabLogs.ResumeLayout(false);
            tabLogs.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialogWorldDirectory;
        private Button btnBrowseWorldDirectory;
        private TabControl tabCtrlMinecraft;
        private TabPage tabDirectories;
        private TabPage tabBehaviorPacks;
        private TabPage tabResourcePacks;
        private Label lblWorldDirectory;
        private TextBox txtWorldDirectory;
        private Button btnBrowseBehaviorPacks;
        private Label lblBehaviorPacks;
        private TextBox txtBehaviorPacks;
        private Button btnBrowseResourcePacks;
        private Label lblResourcePacks;
        private TextBox txtResourcePacks;
        private FolderBrowserDialog folderBrowserDialogBehaviorPacks;
        private FolderBrowserDialog folderBrowserDialogResourcePacks;
        private ListView lstAvailableBehaviorMods;
        private ColumnHeader colBPAvail_Dir;
        private ColumnHeader colBPAvail_ModName;
        private ColumnHeader colBPAvail_Version;
        private Button btnBehaviorPacksRefresh;
        private ColumnHeader colBPAvail_Desc;
        private ListView lstInstalledBehavoirMods;
        private ColumnHeader colBPAvail_UUID;
        private ColumnHeader colBPInstalled_UUID;
        private ColumnHeader colBPInstalled_Dir;
        private ColumnHeader colBPInstalled_Name;
        private ColumnHeader colBPInstalled_Version;
        private ColumnHeader colBPInstalled_Desc;
        private Label lblBehaviorPacksAvailable;
        private Button btnBehaviorPacksDeactivate;
        private Button btnBehaviorPacksActivate;
        private Label lblBehaviorPacksActive;
        private Button btnBehaviorPacksSave;
        private Button btnBehaviorPacksMoveUp;
        private Button btnBehaviorPacksMoveDown;
        private ListView lstInstalledResourceMods;
        private ListView lstAvailableResourceMods;
        private Button btnResourcePacksRefresh;
        private ColumnHeader colRPInstalled_UUID;
        private ColumnHeader colRPAvail_UUID;
        private ColumnHeader colRPAvail_Dir;
        private ColumnHeader colRPAvail_ModName;
        private ColumnHeader colRPAvail_Version;
        private ColumnHeader colRPAvail_Desc;
        private ColumnHeader colRPInstalled_Dir;
        private ColumnHeader colRPInstalled_Name;
        private ColumnHeader colRPInstalled_Version;
        private ColumnHeader colRPInstalled_Desc;
        private Button btnResourcePacksActivate;
        private Button btnResourcePacksDeactivate;
        private Button btnResourcePacksSave;
        private Button btnResourcePacksMoveDown;
        private Button btnResourcePacksMoveUp;
        private CheckBox chkBoxWorldDirectory;
        private CheckBox chkBoxResourcePacks;
        private CheckBox chkBoxBehaviorPacks;
        private TabPage tabLogs;
        private TextBox txtLog;
        private Label lblResourcePacksActive;
        private Label lblResourcePacksAvailable;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatuslbl;
    }
}
