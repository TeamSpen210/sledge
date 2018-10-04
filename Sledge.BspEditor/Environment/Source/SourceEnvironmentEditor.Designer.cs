namespace Sledge.BspEditor.Environment.Source
	{
	partial class SourceEnvironmentEditor
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SourceEnvironmentEditor));
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.grpDirectories = new System.Windows.Forms.GroupBox();
			this.btnGameDirBrowse = new System.Windows.Forms.Button();
			this.txtGameInfo = new System.Windows.Forms.TextBox();
			this.lblGameinfo = new System.Windows.Forms.Label();
			this.fgdSelector = new Sledge.BspEditor.Environment.Controls.FGDSelector();
			this.grpDirectories.SuspendLayout();
			this.SuspendLayout();
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// grpDirectories
			// 
			this.grpDirectories.Controls.Add(this.btnGameDirBrowse);
			this.grpDirectories.Controls.Add(this.txtGameInfo);
			this.grpDirectories.Controls.Add(this.lblGameinfo);
			this.grpDirectories.Location = new System.Drawing.Point(16, 18);
			this.grpDirectories.Name = "grpDirectories";
			this.grpDirectories.Size = new System.Drawing.Size(902, 113);
			this.grpDirectories.TabIndex = 0;
			this.grpDirectories.TabStop = false;
			this.grpDirectories.Text = "Directories";
			// 
			// btnGameDirBrowse
			// 
			this.btnGameDirBrowse.Location = new System.Drawing.Point(745, 39);
			this.btnGameDirBrowse.Margin = new System.Windows.Forms.Padding(6);
			this.btnGameDirBrowse.Name = "btnGameDirBrowse";
			this.btnGameDirBrowse.Size = new System.Drawing.Size(148, 38);
			this.btnGameDirBrowse.TabIndex = 16;
			this.btnGameDirBrowse.Text = "Browse...";
			this.btnGameDirBrowse.UseVisualStyleBackColor = true;
			this.btnGameDirBrowse.Click += new System.EventHandler(this.BrowseGameInfo);
			// 
			// txtGameInfo
			// 
			this.txtGameInfo.Location = new System.Drawing.Point(170, 43);
			this.txtGameInfo.Name = "txtGameInfo";
			this.txtGameInfo.Size = new System.Drawing.Size(566, 31);
			this.txtGameInfo.TabIndex = 1;
			this.txtGameInfo.Text = "example: SteamApps/common/Half Life 2/hl2/gameinfo.txt";
			this.txtGameInfo.DoubleClick += new System.EventHandler(this.BrowseGameInfo);
			// 
			// lblGameinfo
			// 
			this.lblGameinfo.AutoSize = true;
			this.lblGameinfo.Location = new System.Drawing.Point(30, 43);
			this.lblGameinfo.Name = "lblGameinfo";
			this.lblGameinfo.Size = new System.Drawing.Size(133, 25);
			this.lblGameinfo.TabIndex = 0;
			this.lblGameinfo.Text = "Gameinfo.txt";
			// 
			// fgdSelector
			// 
			this.fgdSelector.defaultBrushEntity = "";
			this.fgdSelector.defaultPointEntity = "";
			this.fgdSelector.FgdFilesLabel = "Forge Game Data files";
			this.fgdSelector.fileList = ((System.Collections.Generic.List<string>)(resources.GetObject("fgdSelector.fileList")));
			this.fgdSelector.Location = new System.Drawing.Point(13, 137);
			this.fgdSelector.mapSizeOverrideHigh = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.fgdSelector.mapSizeOverrideLow = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.fgdSelector.Name = "fgdSelector";
			this.fgdSelector.overrideMapSize = true;
			this.fgdSelector.Size = new System.Drawing.Size(905, 596);
			this.fgdSelector.TabIndex = 1;
			// 
			// SourceEnvironmentEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.fgdSelector);
			this.Controls.Add(this.grpDirectories);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "SourceEnvironmentEditor";
			this.Size = new System.Drawing.Size(932, 2312);
			this.grpDirectories.ResumeLayout(false);
			this.grpDirectories.PerformLayout();
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.GroupBox grpDirectories;
		private System.Windows.Forms.Label lblGameinfo;
		private System.Windows.Forms.TextBox txtGameInfo;
		private System.Windows.Forms.Button btnGameDirBrowse;
		private Controls.FGDSelector fgdSelector;
		}
	}
