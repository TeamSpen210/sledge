namespace Sledge.BspEditor.Environment.Goldsource
{
    partial class GoldsourceEnvironmentEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.lblBaseGame = new System.Windows.Forms.Label();
			this.cmbBaseGame = new System.Windows.Forms.ComboBox();
			this.txtGameDir = new System.Windows.Forms.TextBox();
			this.lblGameDir = new System.Windows.Forms.Label();
			this.btnGameDirBrowse = new System.Windows.Forms.Button();
			this.lblGameExe = new System.Windows.Forms.Label();
			this.lblGameMod = new System.Windows.Forms.Label();
			this.cmbGameExe = new System.Windows.Forms.ComboBox();
			this.cmbGameMod = new System.Windows.Forms.ComboBox();
			this.nudDefaultTextureScale = new System.Windows.Forms.NumericUpDown();
			this.lblDefaultTextureScale = new System.Windows.Forms.Label();
			this.chkIncludeFgdDirectories = new System.Windows.Forms.CheckBox();
			this.chkLoadHdModels = new System.Windows.Forms.CheckBox();
			this.grpDirectories = new System.Windows.Forms.GroupBox();
			this.grpBuildTools = new System.Windows.Forms.GroupBox();
			this.lblCopyToMapFolder = new System.Windows.Forms.Label();
			this.chkCopyBsp = new System.Windows.Forms.CheckBox();
			this.chkCopyRes = new System.Windows.Forms.CheckBox();
			this.chkCopyErr = new System.Windows.Forms.CheckBox();
			this.chkCopyLog = new System.Windows.Forms.CheckBox();
			this.chkCopyMap = new System.Windows.Forms.CheckBox();
			this.chkMapCopyBsp = new System.Windows.Forms.CheckBox();
			this.chkAskRunGame = new System.Windows.Forms.CheckBox();
			this.chkRunGame = new System.Windows.Forms.CheckBox();
			this.chkIncludeToolsDirectory = new System.Windows.Forms.CheckBox();
			this.lblBuildExeFolder = new System.Windows.Forms.Label();
			this.lblBuildBSP = new System.Windows.Forms.Label();
			this.txtBuildToolsDirectory = new System.Windows.Forms.TextBox();
			this.lblBuildCSG = new System.Windows.Forms.Label();
			this.cmbRadExe = new System.Windows.Forms.ComboBox();
			this.cmbBspExe = new System.Windows.Forms.ComboBox();
			this.lblBuildVIS = new System.Windows.Forms.Label();
			this.cmbVisExe = new System.Windows.Forms.ComboBox();
			this.cmbCsgExe = new System.Windows.Forms.ComboBox();
			this.lblBuildRAD = new System.Windows.Forms.Label();
			this.btnBuildToolsBrowse = new System.Windows.Forms.Button();
			this.grpTextures = new System.Windows.Forms.GroupBox();
			this.lstAdditionalTextures = new System.Windows.Forms.ListView();
			this.colWadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colWadPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnRemoveTextures = new System.Windows.Forms.Button();
			this.btnAddTextures = new System.Windows.Forms.Button();
			this.lblAdditionalTexturePackages = new System.Windows.Forms.Label();
			this.lblTexturePackageExclusions = new System.Windows.Forms.Label();
			this.cklTexturePackages = new System.Windows.Forms.CheckedListBox();
			this.chkToggleAllTextures = new System.Windows.Forms.CheckBox();
			this.fgdSelector = new Sledge.BspEditor.Environment.Controls.FGDSelector();
			((System.ComponentModel.ISupportInitialize)(this.nudDefaultTextureScale)).BeginInit();
			this.grpDirectories.SuspendLayout();
			this.grpBuildTools.SuspendLayout();
			this.grpTextures.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblBaseGame
			// 
			this.lblBaseGame.Location = new System.Drawing.Point(4, 79);
			this.lblBaseGame.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblBaseGame.Name = "lblBaseGame";
			this.lblBaseGame.Size = new System.Drawing.Size(396, 38);
			this.lblBaseGame.TabIndex = 20;
			this.lblBaseGame.Text = "Base Game Directory (e.g. \'valve\')";
			this.lblBaseGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbBaseGame
			// 
			this.cmbBaseGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBaseGame.FormattingEnabled = true;
			this.cmbBaseGame.Items.AddRange(new object[] {
            "(Steam only) Half-Life",
            "Counter-Strike"});
			this.cmbBaseGame.Location = new System.Drawing.Point(420, 81);
			this.cmbBaseGame.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.cmbBaseGame.Name = "cmbBaseGame";
			this.cmbBaseGame.Size = new System.Drawing.Size(302, 33);
			this.cmbBaseGame.TabIndex = 21;
			this.cmbBaseGame.SelectedIndexChanged += new System.EventHandler(this.BaseGameDirectoryChanged);
			// 
			// txtGameDir
			// 
			this.txtGameDir.Location = new System.Drawing.Point(214, 31);
			this.txtGameDir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.txtGameDir.Name = "txtGameDir";
			this.txtGameDir.Size = new System.Drawing.Size(508, 31);
			this.txtGameDir.TabIndex = 13;
			this.txtGameDir.Text = "example: C:\\Sierra\\Half-Life";
			this.txtGameDir.TextChanged += new System.EventHandler(this.GameDirectoryTextChanged);
			// 
			// lblGameDir
			// 
			this.lblGameDir.Location = new System.Drawing.Point(12, 31);
			this.lblGameDir.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblGameDir.Name = "lblGameDir";
			this.lblGameDir.Size = new System.Drawing.Size(190, 38);
			this.lblGameDir.TabIndex = 14;
			this.lblGameDir.Text = "Game Dir";
			this.lblGameDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnGameDirBrowse
			// 
			this.btnGameDirBrowse.Location = new System.Drawing.Point(738, 31);
			this.btnGameDirBrowse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnGameDirBrowse.Name = "btnGameDirBrowse";
			this.btnGameDirBrowse.Size = new System.Drawing.Size(148, 38);
			this.btnGameDirBrowse.TabIndex = 15;
			this.btnGameDirBrowse.Text = "Browse...";
			this.btnGameDirBrowse.UseVisualStyleBackColor = true;
			this.btnGameDirBrowse.Click += new System.EventHandler(this.BrowseGameDirectory);
			// 
			// lblGameExe
			// 
			this.lblGameExe.Location = new System.Drawing.Point(6, 183);
			this.lblGameExe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblGameExe.Name = "lblGameExe";
			this.lblGameExe.Size = new System.Drawing.Size(396, 38);
			this.lblGameExe.TabIndex = 16;
			this.lblGameExe.Text = "Game Executable (e.g. \'hl.exe\')";
			this.lblGameExe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblGameMod
			// 
			this.lblGameMod.Location = new System.Drawing.Point(4, 131);
			this.lblGameMod.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblGameMod.Name = "lblGameMod";
			this.lblGameMod.Size = new System.Drawing.Size(396, 38);
			this.lblGameMod.TabIndex = 17;
			this.lblGameMod.Text = "Mod Directory (e.g. \'cstrike\')";
			this.lblGameMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbGameExe
			// 
			this.cmbGameExe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGameExe.FormattingEnabled = true;
			this.cmbGameExe.Items.AddRange(new object[] {
            "Valve"});
			this.cmbGameExe.Location = new System.Drawing.Point(420, 185);
			this.cmbGameExe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.cmbGameExe.Name = "cmbGameExe";
			this.cmbGameExe.Size = new System.Drawing.Size(302, 33);
			this.cmbGameExe.TabIndex = 18;
			// 
			// cmbGameMod
			// 
			this.cmbGameMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGameMod.FormattingEnabled = true;
			this.cmbGameMod.Items.AddRange(new object[] {
            "Valve"});
			this.cmbGameMod.Location = new System.Drawing.Point(420, 133);
			this.cmbGameMod.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.cmbGameMod.Name = "cmbGameMod";
			this.cmbGameMod.Size = new System.Drawing.Size(302, 33);
			this.cmbGameMod.TabIndex = 19;
			this.cmbGameMod.SelectedIndexChanged += new System.EventHandler(this.ModDirectoryChanged);
			// 
			// nudDefaultTextureScale
			// 
			this.nudDefaultTextureScale.DecimalPlaces = 2;
			this.nudDefaultTextureScale.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.nudDefaultTextureScale.Location = new System.Drawing.Point(396, 31);
			this.nudDefaultTextureScale.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.nudDefaultTextureScale.Name = "nudDefaultTextureScale";
			this.nudDefaultTextureScale.Size = new System.Drawing.Size(102, 31);
			this.nudDefaultTextureScale.TabIndex = 38;
			this.nudDefaultTextureScale.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
			// 
			// lblDefaultTextureScale
			// 
			this.lblDefaultTextureScale.Location = new System.Drawing.Point(12, 31);
			this.lblDefaultTextureScale.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblDefaultTextureScale.Name = "lblDefaultTextureScale";
			this.lblDefaultTextureScale.Size = new System.Drawing.Size(372, 38);
			this.lblDefaultTextureScale.TabIndex = 36;
			this.lblDefaultTextureScale.Text = "Default Texture Scale";
			this.lblDefaultTextureScale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkIncludeFgdDirectories
			// 
			this.chkIncludeFgdDirectories.Checked = true;
			this.chkIncludeFgdDirectories.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkIncludeFgdDirectories.Location = new System.Drawing.Point(51, 830);
			this.chkIncludeFgdDirectories.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.chkIncludeFgdDirectories.Name = "chkIncludeFgdDirectories";
			this.chkIncludeFgdDirectories.Size = new System.Drawing.Size(502, 46);
			this.chkIncludeFgdDirectories.TabIndex = 39;
			this.chkIncludeFgdDirectories.Text = "Load sprites and models from FGD directories";
			this.chkIncludeFgdDirectories.UseVisualStyleBackColor = true;
			// 
			// chkLoadHdModels
			// 
			this.chkLoadHdModels.Checked = true;
			this.chkLoadHdModels.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkLoadHdModels.Location = new System.Drawing.Point(420, 237);
			this.chkLoadHdModels.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.chkLoadHdModels.Name = "chkLoadHdModels";
			this.chkLoadHdModels.Size = new System.Drawing.Size(354, 46);
			this.chkLoadHdModels.TabIndex = 45;
			this.chkLoadHdModels.Text = "Load HD Models (if available)";
			this.chkLoadHdModels.UseVisualStyleBackColor = true;
			// 
			// grpDirectories
			// 
			this.grpDirectories.Controls.Add(this.lblGameDir);
			this.grpDirectories.Controls.Add(this.cmbGameMod);
			this.grpDirectories.Controls.Add(this.chkLoadHdModels);
			this.grpDirectories.Controls.Add(this.cmbGameExe);
			this.grpDirectories.Controls.Add(this.lblGameMod);
			this.grpDirectories.Controls.Add(this.lblGameExe);
			this.grpDirectories.Controls.Add(this.btnGameDirBrowse);
			this.grpDirectories.Controls.Add(this.txtGameDir);
			this.grpDirectories.Controls.Add(this.cmbBaseGame);
			this.grpDirectories.Controls.Add(this.lblBaseGame);
			this.grpDirectories.Location = new System.Drawing.Point(12, 6);
			this.grpDirectories.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.grpDirectories.Name = "grpDirectories";
			this.grpDirectories.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.grpDirectories.Size = new System.Drawing.Size(918, 308);
			this.grpDirectories.TabIndex = 46;
			this.grpDirectories.TabStop = false;
			this.grpDirectories.Text = "Directories";
			// 
			// grpBuildTools
			// 
			this.grpBuildTools.Controls.Add(this.lblCopyToMapFolder);
			this.grpBuildTools.Controls.Add(this.chkCopyBsp);
			this.grpBuildTools.Controls.Add(this.chkCopyRes);
			this.grpBuildTools.Controls.Add(this.chkCopyErr);
			this.grpBuildTools.Controls.Add(this.chkCopyLog);
			this.grpBuildTools.Controls.Add(this.chkCopyMap);
			this.grpBuildTools.Controls.Add(this.chkMapCopyBsp);
			this.grpBuildTools.Controls.Add(this.chkAskRunGame);
			this.grpBuildTools.Controls.Add(this.chkRunGame);
			this.grpBuildTools.Controls.Add(this.chkIncludeToolsDirectory);
			this.grpBuildTools.Controls.Add(this.lblBuildExeFolder);
			this.grpBuildTools.Controls.Add(this.lblBuildBSP);
			this.grpBuildTools.Controls.Add(this.txtBuildToolsDirectory);
			this.grpBuildTools.Controls.Add(this.lblBuildCSG);
			this.grpBuildTools.Controls.Add(this.cmbRadExe);
			this.grpBuildTools.Controls.Add(this.cmbBspExe);
			this.grpBuildTools.Controls.Add(this.lblBuildVIS);
			this.grpBuildTools.Controls.Add(this.cmbVisExe);
			this.grpBuildTools.Controls.Add(this.cmbCsgExe);
			this.grpBuildTools.Controls.Add(this.lblBuildRAD);
			this.grpBuildTools.Controls.Add(this.btnBuildToolsBrowse);
			this.grpBuildTools.Location = new System.Drawing.Point(12, 921);
			this.grpBuildTools.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.grpBuildTools.Name = "grpBuildTools";
			this.grpBuildTools.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.grpBuildTools.Size = new System.Drawing.Size(918, 590);
			this.grpBuildTools.TabIndex = 48;
			this.grpBuildTools.TabStop = false;
			this.grpBuildTools.Text = "Build Tools";
			// 
			// lblCopyToMapFolder
			// 
			this.lblCopyToMapFolder.Location = new System.Drawing.Point(12, 533);
			this.lblCopyToMapFolder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblCopyToMapFolder.Name = "lblCopyToMapFolder";
			this.lblCopyToMapFolder.Size = new System.Drawing.Size(296, 38);
			this.lblCopyToMapFolder.TabIndex = 43;
			this.lblCopyToMapFolder.Text = "Copy to map folder:";
			this.lblCopyToMapFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkCopyBsp
			// 
			this.chkCopyBsp.Checked = true;
			this.chkCopyBsp.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCopyBsp.Location = new System.Drawing.Point(150, 388);
			this.chkCopyBsp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.chkCopyBsp.Name = "chkCopyBsp";
			this.chkCopyBsp.Size = new System.Drawing.Size(736, 38);
			this.chkCopyBsp.TabIndex = 42;
			this.chkCopyBsp.Text = "Copy BSP/RES to game folder";
			this.chkCopyBsp.UseVisualStyleBackColor = true;
			// 
			// chkCopyRes
			// 
			this.chkCopyRes.Checked = true;
			this.chkCopyRes.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCopyRes.Location = new System.Drawing.Point(690, 531);
			this.chkCopyRes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.chkCopyRes.Name = "chkCopyRes";
			this.chkCopyRes.Size = new System.Drawing.Size(98, 46);
			this.chkCopyRes.TabIndex = 42;
			this.chkCopyRes.Text = "RES";
			this.chkCopyRes.UseVisualStyleBackColor = true;
			// 
			// chkCopyErr
			// 
			this.chkCopyErr.Checked = true;
			this.chkCopyErr.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCopyErr.Location = new System.Drawing.Point(596, 531);
			this.chkCopyErr.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.chkCopyErr.Name = "chkCopyErr";
			this.chkCopyErr.Size = new System.Drawing.Size(98, 46);
			this.chkCopyErr.TabIndex = 42;
			this.chkCopyErr.Text = "ERR";
			this.chkCopyErr.UseVisualStyleBackColor = true;
			// 
			// chkCopyLog
			// 
			this.chkCopyLog.Checked = true;
			this.chkCopyLog.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCopyLog.Location = new System.Drawing.Point(500, 531);
			this.chkCopyLog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.chkCopyLog.Name = "chkCopyLog";
			this.chkCopyLog.Size = new System.Drawing.Size(98, 46);
			this.chkCopyLog.TabIndex = 42;
			this.chkCopyLog.Text = "LOG";
			this.chkCopyLog.UseVisualStyleBackColor = true;
			// 
			// chkCopyMap
			// 
			this.chkCopyMap.Checked = true;
			this.chkCopyMap.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCopyMap.Location = new System.Drawing.Point(408, 531);
			this.chkCopyMap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.chkCopyMap.Name = "chkCopyMap";
			this.chkCopyMap.Size = new System.Drawing.Size(98, 46);
			this.chkCopyMap.TabIndex = 42;
			this.chkCopyMap.Text = "MAP";
			this.chkCopyMap.UseVisualStyleBackColor = true;
			// 
			// chkMapCopyBsp
			// 
			this.chkMapCopyBsp.Checked = true;
			this.chkMapCopyBsp.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkMapCopyBsp.Location = new System.Drawing.Point(320, 531);
			this.chkMapCopyBsp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.chkMapCopyBsp.Name = "chkMapCopyBsp";
			this.chkMapCopyBsp.Size = new System.Drawing.Size(98, 46);
			this.chkMapCopyBsp.TabIndex = 42;
			this.chkMapCopyBsp.Text = "BSP";
			this.chkMapCopyBsp.UseVisualStyleBackColor = true;
			// 
			// chkAskRunGame
			// 
			this.chkAskRunGame.Checked = true;
			this.chkAskRunGame.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAskRunGame.Location = new System.Drawing.Point(150, 488);
			this.chkAskRunGame.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.chkAskRunGame.Name = "chkAskRunGame";
			this.chkAskRunGame.Size = new System.Drawing.Size(736, 38);
			this.chkAskRunGame.TabIndex = 42;
			this.chkAskRunGame.Text = "Ask before running the game";
			this.chkAskRunGame.UseVisualStyleBackColor = true;
			// 
			// chkRunGame
			// 
			this.chkRunGame.Checked = true;
			this.chkRunGame.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkRunGame.Location = new System.Drawing.Point(150, 438);
			this.chkRunGame.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.chkRunGame.Name = "chkRunGame";
			this.chkRunGame.Size = new System.Drawing.Size(736, 38);
			this.chkRunGame.TabIndex = 42;
			this.chkRunGame.Text = "Run the game after successful compile";
			this.chkRunGame.UseVisualStyleBackColor = true;
			// 
			// chkIncludeToolsDirectory
			// 
			this.chkIncludeToolsDirectory.Checked = true;
			this.chkIncludeToolsDirectory.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkIncludeToolsDirectory.Location = new System.Drawing.Point(18, 123);
			this.chkIncludeToolsDirectory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.chkIncludeToolsDirectory.Name = "chkIncludeToolsDirectory";
			this.chkIncludeToolsDirectory.Size = new System.Drawing.Size(868, 38);
			this.chkIncludeToolsDirectory.TabIndex = 33;
			this.chkIncludeToolsDirectory.Text = "Automatically include textures found in this directory";
			this.chkIncludeToolsDirectory.UseVisualStyleBackColor = true;
			this.chkIncludeToolsDirectory.CheckedChanged += new System.EventHandler(this.IncludeBuildToolsChanged);
			// 
			// lblBuildExeFolder
			// 
			this.lblBuildExeFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblBuildExeFolder.Location = new System.Drawing.Point(12, 31);
			this.lblBuildExeFolder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblBuildExeFolder.Name = "lblBuildExeFolder";
			this.lblBuildExeFolder.Size = new System.Drawing.Size(352, 38);
			this.lblBuildExeFolder.TabIndex = 27;
			this.lblBuildExeFolder.Text = "Folder containing build executables:";
			this.lblBuildExeFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblBuildBSP
			// 
			this.lblBuildBSP.Location = new System.Drawing.Point(70, 175);
			this.lblBuildBSP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblBuildBSP.Name = "lblBuildBSP";
			this.lblBuildBSP.Size = new System.Drawing.Size(68, 38);
			this.lblBuildBSP.TabIndex = 23;
			this.lblBuildBSP.Text = "BSP";
			this.lblBuildBSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtBuildToolsDirectory
			// 
			this.txtBuildToolsDirectory.Location = new System.Drawing.Point(18, 73);
			this.txtBuildToolsDirectory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.txtBuildToolsDirectory.Name = "txtBuildToolsDirectory";
			this.txtBuildToolsDirectory.Size = new System.Drawing.Size(704, 31);
			this.txtBuildToolsDirectory.TabIndex = 22;
			this.txtBuildToolsDirectory.Text = "example: C:\\hammer_alt";
			this.txtBuildToolsDirectory.TextChanged += new System.EventHandler(this.BuildToolsDirectoryTextChanged);
			// 
			// lblBuildCSG
			// 
			this.lblBuildCSG.Location = new System.Drawing.Point(70, 227);
			this.lblBuildCSG.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblBuildCSG.Name = "lblBuildCSG";
			this.lblBuildCSG.Size = new System.Drawing.Size(68, 38);
			this.lblBuildCSG.TabIndex = 24;
			this.lblBuildCSG.Text = "CSG";
			this.lblBuildCSG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbRadExe
			// 
			this.cmbRadExe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRadExe.FormattingEnabled = true;
			this.cmbRadExe.Location = new System.Drawing.Point(150, 329);
			this.cmbRadExe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.cmbRadExe.Name = "cmbRadExe";
			this.cmbRadExe.Size = new System.Drawing.Size(302, 33);
			this.cmbRadExe.TabIndex = 28;
			// 
			// cmbBspExe
			// 
			this.cmbBspExe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBspExe.FormattingEnabled = true;
			this.cmbBspExe.Location = new System.Drawing.Point(150, 173);
			this.cmbBspExe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.cmbBspExe.Name = "cmbBspExe";
			this.cmbBspExe.Size = new System.Drawing.Size(302, 33);
			this.cmbBspExe.TabIndex = 29;
			// 
			// lblBuildVIS
			// 
			this.lblBuildVIS.Location = new System.Drawing.Point(70, 279);
			this.lblBuildVIS.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblBuildVIS.Name = "lblBuildVIS";
			this.lblBuildVIS.Size = new System.Drawing.Size(68, 38);
			this.lblBuildVIS.TabIndex = 25;
			this.lblBuildVIS.Text = "VIS";
			this.lblBuildVIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbVisExe
			// 
			this.cmbVisExe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbVisExe.FormattingEnabled = true;
			this.cmbVisExe.Location = new System.Drawing.Point(150, 277);
			this.cmbVisExe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.cmbVisExe.Name = "cmbVisExe";
			this.cmbVisExe.Size = new System.Drawing.Size(302, 33);
			this.cmbVisExe.TabIndex = 30;
			// 
			// cmbCsgExe
			// 
			this.cmbCsgExe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCsgExe.FormattingEnabled = true;
			this.cmbCsgExe.Location = new System.Drawing.Point(150, 225);
			this.cmbCsgExe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.cmbCsgExe.Name = "cmbCsgExe";
			this.cmbCsgExe.Size = new System.Drawing.Size(302, 33);
			this.cmbCsgExe.TabIndex = 31;
			// 
			// lblBuildRAD
			// 
			this.lblBuildRAD.Location = new System.Drawing.Point(70, 331);
			this.lblBuildRAD.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblBuildRAD.Name = "lblBuildRAD";
			this.lblBuildRAD.Size = new System.Drawing.Size(68, 38);
			this.lblBuildRAD.TabIndex = 26;
			this.lblBuildRAD.Text = "RAD";
			this.lblBuildRAD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnBuildToolsBrowse
			// 
			this.btnBuildToolsBrowse.Location = new System.Drawing.Point(738, 73);
			this.btnBuildToolsBrowse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnBuildToolsBrowse.Name = "btnBuildToolsBrowse";
			this.btnBuildToolsBrowse.Size = new System.Drawing.Size(148, 38);
			this.btnBuildToolsBrowse.TabIndex = 32;
			this.btnBuildToolsBrowse.Text = "Browse...";
			this.btnBuildToolsBrowse.UseVisualStyleBackColor = true;
			this.btnBuildToolsBrowse.Click += new System.EventHandler(this.BrowseBuildToolsDirectory);
			// 
			// grpTextures
			// 
			this.grpTextures.Controls.Add(this.lstAdditionalTextures);
			this.grpTextures.Controls.Add(this.btnRemoveTextures);
			this.grpTextures.Controls.Add(this.btnAddTextures);
			this.grpTextures.Controls.Add(this.lblAdditionalTexturePackages);
			this.grpTextures.Controls.Add(this.lblTexturePackageExclusions);
			this.grpTextures.Controls.Add(this.cklTexturePackages);
			this.grpTextures.Controls.Add(this.chkToggleAllTextures);
			this.grpTextures.Controls.Add(this.lblDefaultTextureScale);
			this.grpTextures.Controls.Add(this.nudDefaultTextureScale);
			this.grpTextures.Location = new System.Drawing.Point(12, 1523);
			this.grpTextures.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.grpTextures.Name = "grpTextures";
			this.grpTextures.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.grpTextures.Size = new System.Drawing.Size(918, 783);
			this.grpTextures.TabIndex = 49;
			this.grpTextures.TabStop = false;
			this.grpTextures.Text = "Textures";
			// 
			// lstAdditionalTextures
			// 
			this.lstAdditionalTextures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colWadName,
            this.colWadPath});
			this.lstAdditionalTextures.FullRowSelect = true;
			this.lstAdditionalTextures.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstAdditionalTextures.Location = new System.Drawing.Point(18, 488);
			this.lstAdditionalTextures.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.lstAdditionalTextures.Name = "lstAdditionalTextures";
			this.lstAdditionalTextures.ShowItemToolTips = true;
			this.lstAdditionalTextures.Size = new System.Drawing.Size(724, 279);
			this.lstAdditionalTextures.TabIndex = 45;
			this.lstAdditionalTextures.UseCompatibleStateImageBehavior = false;
			this.lstAdditionalTextures.View = System.Windows.Forms.View.Details;
			// 
			// colWadName
			// 
			this.colWadName.Text = "Name";
			// 
			// colWadPath
			// 
			this.colWadPath.Text = "Path";
			// 
			// btnRemoveTextures
			// 
			this.btnRemoveTextures.Location = new System.Drawing.Point(758, 544);
			this.btnRemoveTextures.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnRemoveTextures.Name = "btnRemoveTextures";
			this.btnRemoveTextures.Size = new System.Drawing.Size(148, 44);
			this.btnRemoveTextures.TabIndex = 44;
			this.btnRemoveTextures.Text = "Remove";
			this.btnRemoveTextures.UseVisualStyleBackColor = true;
			this.btnRemoveTextures.Click += new System.EventHandler(this.RemoveWad);
			// 
			// btnAddTextures
			// 
			this.btnAddTextures.Location = new System.Drawing.Point(758, 488);
			this.btnAddTextures.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnAddTextures.Name = "btnAddTextures";
			this.btnAddTextures.Size = new System.Drawing.Size(148, 44);
			this.btnAddTextures.TabIndex = 43;
			this.btnAddTextures.Text = "Add...";
			this.btnAddTextures.UseVisualStyleBackColor = true;
			this.btnAddTextures.Click += new System.EventHandler(this.BrowseWad);
			// 
			// lblAdditionalTexturePackages
			// 
			this.lblAdditionalTexturePackages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblAdditionalTexturePackages.Location = new System.Drawing.Point(12, 444);
			this.lblAdditionalTexturePackages.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblAdditionalTexturePackages.Name = "lblAdditionalTexturePackages";
			this.lblAdditionalTexturePackages.Size = new System.Drawing.Size(714, 38);
			this.lblAdditionalTexturePackages.TabIndex = 34;
			this.lblAdditionalTexturePackages.Text = "Additional texture packages:";
			this.lblAdditionalTexturePackages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTexturePackageExclusions
			// 
			this.lblTexturePackageExclusions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTexturePackageExclusions.Location = new System.Drawing.Point(24, 69);
			this.lblTexturePackageExclusions.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblTexturePackageExclusions.Name = "lblTexturePackageExclusions";
			this.lblTexturePackageExclusions.Size = new System.Drawing.Size(644, 38);
			this.lblTexturePackageExclusions.TabIndex = 34;
			this.lblTexturePackageExclusions.Text = "Texture packages to include:";
			this.lblTexturePackageExclusions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cklTexturePackages
			// 
			this.cklTexturePackages.CheckOnClick = true;
			this.cklTexturePackages.FormattingEnabled = true;
			this.cklTexturePackages.Location = new System.Drawing.Point(18, 113);
			this.cklTexturePackages.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.cklTexturePackages.Name = "cklTexturePackages";
			this.cklTexturePackages.Size = new System.Drawing.Size(884, 316);
			this.cklTexturePackages.TabIndex = 39;
			// 
			// chkToggleAllTextures
			// 
			this.chkToggleAllTextures.Checked = true;
			this.chkToggleAllTextures.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkToggleAllTextures.Location = new System.Drawing.Point(744, 79);
			this.chkToggleAllTextures.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.chkToggleAllTextures.Name = "chkToggleAllTextures";
			this.chkToggleAllTextures.Size = new System.Drawing.Size(162, 35);
			this.chkToggleAllTextures.TabIndex = 42;
			this.chkToggleAllTextures.Text = "Toggle all";
			this.chkToggleAllTextures.UseVisualStyleBackColor = true;
			this.chkToggleAllTextures.CheckedChanged += new System.EventHandler(this.ToggleAllTextures);
			// 
			// fgdSelector
			// 
			this.fgdSelector.FgdFilesLabel = "Forge Game Data files";
			this.fgdSelector.Location = new System.Drawing.Point(12, 316);
			this.fgdSelector.Name = "fgdSelector";
			this.fgdSelector.Size = new System.Drawing.Size(928, 596);
			this.fgdSelector.TabIndex = 50;
			// 
			// GoldsourceEnvironmentEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.chkIncludeFgdDirectories);
			this.Controls.Add(this.fgdSelector);
			this.Controls.Add(this.grpTextures);
			this.Controls.Add(this.grpBuildTools);
			this.Controls.Add(this.grpDirectories);
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "GoldsourceEnvironmentEditor";
			this.Size = new System.Drawing.Size(944, 2312);
			((System.ComponentModel.ISupportInitialize)(this.nudDefaultTextureScale)).EndInit();
			this.grpDirectories.ResumeLayout(false);
			this.grpDirectories.PerformLayout();
			this.grpBuildTools.ResumeLayout(false);
			this.grpBuildTools.PerformLayout();
			this.grpTextures.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBaseGame;
        private System.Windows.Forms.ComboBox cmbBaseGame;
        private System.Windows.Forms.TextBox txtGameDir;
        private System.Windows.Forms.Label lblGameDir;
        private System.Windows.Forms.Button btnGameDirBrowse;
        private System.Windows.Forms.Label lblGameExe;
        private System.Windows.Forms.Label lblGameMod;
        private System.Windows.Forms.ComboBox cmbGameExe;
        private System.Windows.Forms.ComboBox cmbGameMod;
        private System.Windows.Forms.NumericUpDown nudDefaultTextureScale;
        private System.Windows.Forms.Label lblDefaultTextureScale;
        private System.Windows.Forms.CheckBox chkIncludeFgdDirectories;
        private System.Windows.Forms.CheckBox chkLoadHdModels;
        private System.Windows.Forms.GroupBox grpDirectories;
        private System.Windows.Forms.GroupBox grpBuildTools;
        private System.Windows.Forms.CheckBox chkIncludeToolsDirectory;
        private System.Windows.Forms.Label lblBuildExeFolder;
        private System.Windows.Forms.Label lblBuildBSP;
        private System.Windows.Forms.TextBox txtBuildToolsDirectory;
        private System.Windows.Forms.Label lblBuildCSG;
        private System.Windows.Forms.ComboBox cmbRadExe;
        private System.Windows.Forms.ComboBox cmbBspExe;
        private System.Windows.Forms.Label lblBuildVIS;
        private System.Windows.Forms.ComboBox cmbVisExe;
        private System.Windows.Forms.ComboBox cmbCsgExe;
        private System.Windows.Forms.Label lblBuildRAD;
        private System.Windows.Forms.Button btnBuildToolsBrowse;
        private System.Windows.Forms.GroupBox grpTextures;
        private System.Windows.Forms.CheckedListBox cklTexturePackages;
        private System.Windows.Forms.Label lblTexturePackageExclusions;
        private System.Windows.Forms.Label lblCopyToMapFolder;
        private System.Windows.Forms.CheckBox chkCopyBsp;
        private System.Windows.Forms.CheckBox chkCopyRes;
        private System.Windows.Forms.CheckBox chkCopyErr;
        private System.Windows.Forms.CheckBox chkCopyLog;
        private System.Windows.Forms.CheckBox chkCopyMap;
        private System.Windows.Forms.CheckBox chkMapCopyBsp;
        private System.Windows.Forms.CheckBox chkAskRunGame;
        private System.Windows.Forms.CheckBox chkRunGame;
        private System.Windows.Forms.CheckBox chkToggleAllTextures;
        private System.Windows.Forms.ListView lstAdditionalTextures;
        private System.Windows.Forms.ColumnHeader colWadName;
        private System.Windows.Forms.ColumnHeader colWadPath;
        private System.Windows.Forms.Button btnRemoveTextures;
        private System.Windows.Forms.Button btnAddTextures;
        private System.Windows.Forms.Label lblAdditionalTexturePackages;
		private Controls.FGDSelector fgdSelector;
		}
}
