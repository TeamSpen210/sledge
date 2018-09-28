namespace Sledge.BspEditor.Environment.Controls
	{
	partial class FGDSelector
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
			this.lstFgds = new System.Windows.Forms.ListView();
			this.colFgdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFgdPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.grpFgds = new System.Windows.Forms.GroupBox();
			this.cmbDefaultPointEntity = new System.Windows.Forms.ComboBox();
			this.cmbDefaultBrushEntity = new System.Windows.Forms.ComboBox();
			this.cmbMapSizeOverrideHigh = new System.Windows.Forms.ComboBox();
			this.lblDefaultPointEntity = new System.Windows.Forms.Label();
			this.lblMapSizeOverrideHigh = new System.Windows.Forms.Label();
			this.btnRemoveFgd = new System.Windows.Forms.Button();
			this.cmbMapSizeOverrideLow = new System.Windows.Forms.ComboBox();
			this.lblDefaultBrushEntity = new System.Windows.Forms.Label();
			this.chkOverrideMapSize = new System.Windows.Forms.CheckBox();
			this.btnAddFgd = new System.Windows.Forms.Button();
			this.lblMapSizeOverrideLow = new System.Windows.Forms.Label();
			this.grpFgds.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstFgds
			// 
			this.lstFgds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFgdName,
            this.colFgdPath});
			this.lstFgds.FullRowSelect = true;
			this.lstFgds.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstFgds.Location = new System.Drawing.Point(12, 37);
			this.lstFgds.Margin = new System.Windows.Forms.Padding(6);
			this.lstFgds.Name = "lstFgds";
			this.lstFgds.ShowItemToolTips = true;
			this.lstFgds.Size = new System.Drawing.Size(710, 304);
			this.lstFgds.TabIndex = 34;
			this.lstFgds.UseCompatibleStateImageBehavior = false;
			this.lstFgds.View = System.Windows.Forms.View.Details;
			// 
			// colFgdName
			// 
			this.colFgdName.Text = "Name";
			// 
			// colFgdPath
			// 
			this.colFgdPath.Text = "Path";
			// 
			// grpFgds
			// 
			this.grpFgds.Controls.Add(this.lstFgds);
			this.grpFgds.Controls.Add(this.cmbDefaultPointEntity);
			this.grpFgds.Controls.Add(this.cmbDefaultBrushEntity);
			this.grpFgds.Controls.Add(this.cmbMapSizeOverrideHigh);
			this.grpFgds.Controls.Add(this.lblDefaultPointEntity);
			this.grpFgds.Controls.Add(this.lblMapSizeOverrideHigh);
			this.grpFgds.Controls.Add(this.btnRemoveFgd);
			this.grpFgds.Controls.Add(this.cmbMapSizeOverrideLow);
			this.grpFgds.Controls.Add(this.lblDefaultBrushEntity);
			this.grpFgds.Controls.Add(this.chkOverrideMapSize);
			this.grpFgds.Controls.Add(this.btnAddFgd);
			this.grpFgds.Controls.Add(this.lblMapSizeOverrideLow);
			this.grpFgds.Location = new System.Drawing.Point(6, 6);
			this.grpFgds.Margin = new System.Windows.Forms.Padding(6);
			this.grpFgds.Name = "grpFgds";
			this.grpFgds.Padding = new System.Windows.Forms.Padding(6);
			this.grpFgds.Size = new System.Drawing.Size(918, 585);
			this.grpFgds.TabIndex = 48;
			this.grpFgds.TabStop = false;
			this.grpFgds.Text = "Game Data Files";
			// 
			// cmbDefaultPointEntity
			// 
			this.cmbDefaultPointEntity.DropDownHeight = 300;
			this.cmbDefaultPointEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDefaultPointEntity.FormattingEnabled = true;
			this.cmbDefaultPointEntity.IntegralHeight = false;
			this.cmbDefaultPointEntity.Items.AddRange(new object[] {
            "Valve"});
			this.cmbDefaultPointEntity.Location = new System.Drawing.Point(326, 356);
			this.cmbDefaultPointEntity.Margin = new System.Windows.Forms.Padding(6);
			this.cmbDefaultPointEntity.Name = "cmbDefaultPointEntity";
			this.cmbDefaultPointEntity.Size = new System.Drawing.Size(394, 33);
			this.cmbDefaultPointEntity.TabIndex = 33;
			// 
			// cmbDefaultBrushEntity
			// 
			this.cmbDefaultBrushEntity.DropDownHeight = 300;
			this.cmbDefaultBrushEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDefaultBrushEntity.FormattingEnabled = true;
			this.cmbDefaultBrushEntity.IntegralHeight = false;
			this.cmbDefaultBrushEntity.Items.AddRange(new object[] {
            "Valve"});
			this.cmbDefaultBrushEntity.Location = new System.Drawing.Point(326, 408);
			this.cmbDefaultBrushEntity.Margin = new System.Windows.Forms.Padding(6);
			this.cmbDefaultBrushEntity.Name = "cmbDefaultBrushEntity";
			this.cmbDefaultBrushEntity.Size = new System.Drawing.Size(394, 33);
			this.cmbDefaultBrushEntity.TabIndex = 32;
			// 
			// cmbMapSizeOverrideHigh
			// 
			this.cmbMapSizeOverrideHigh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMapSizeOverrideHigh.FormattingEnabled = true;
			this.cmbMapSizeOverrideHigh.Items.AddRange(new object[] {
            "4096",
            "8192",
            "16384",
            "32768",
            "65536",
            "131072"});
			this.cmbMapSizeOverrideHigh.Location = new System.Drawing.Point(610, 460);
			this.cmbMapSizeOverrideHigh.Margin = new System.Windows.Forms.Padding(6);
			this.cmbMapSizeOverrideHigh.Name = "cmbMapSizeOverrideHigh";
			this.cmbMapSizeOverrideHigh.Size = new System.Drawing.Size(110, 33);
			this.cmbMapSizeOverrideHigh.TabIndex = 44;
			// 
			// lblDefaultPointEntity
			// 
			this.lblDefaultPointEntity.Location = new System.Drawing.Point(90, 358);
			this.lblDefaultPointEntity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblDefaultPointEntity.Name = "lblDefaultPointEntity";
			this.lblDefaultPointEntity.Size = new System.Drawing.Size(224, 38);
			this.lblDefaultPointEntity.TabIndex = 31;
			this.lblDefaultPointEntity.Text = "Default Point Entity";
			this.lblDefaultPointEntity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblMapSizeOverrideHigh
			// 
			this.lblMapSizeOverrideHigh.Location = new System.Drawing.Point(528, 458);
			this.lblMapSizeOverrideHigh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblMapSizeOverrideHigh.Name = "lblMapSizeOverrideHigh";
			this.lblMapSizeOverrideHigh.Size = new System.Drawing.Size(70, 38);
			this.lblMapSizeOverrideHigh.TabIndex = 43;
			this.lblMapSizeOverrideHigh.Text = "High";
			this.lblMapSizeOverrideHigh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnRemoveFgd
			// 
			this.btnRemoveFgd.Location = new System.Drawing.Point(738, 92);
			this.btnRemoveFgd.Margin = new System.Windows.Forms.Padding(6);
			this.btnRemoveFgd.Name = "btnRemoveFgd";
			this.btnRemoveFgd.Size = new System.Drawing.Size(148, 44);
			this.btnRemoveFgd.TabIndex = 28;
			this.btnRemoveFgd.Text = "Remove";
			this.btnRemoveFgd.UseVisualStyleBackColor = true;
			this.btnRemoveFgd.Click += new System.EventHandler(this.RemoveFgd);
			// 
			// cmbMapSizeOverrideLow
			// 
			this.cmbMapSizeOverrideLow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMapSizeOverrideLow.FormattingEnabled = true;
			this.cmbMapSizeOverrideLow.Items.AddRange(new object[] {
            "-4096",
            "-8192",
            "-16384",
            "-32768",
            "-65536",
            "-131072"});
			this.cmbMapSizeOverrideLow.Location = new System.Drawing.Point(402, 460);
			this.cmbMapSizeOverrideLow.Margin = new System.Windows.Forms.Padding(6);
			this.cmbMapSizeOverrideLow.Name = "cmbMapSizeOverrideLow";
			this.cmbMapSizeOverrideLow.Size = new System.Drawing.Size(110, 33);
			this.cmbMapSizeOverrideLow.TabIndex = 42;
			// 
			// lblDefaultBrushEntity
			// 
			this.lblDefaultBrushEntity.Location = new System.Drawing.Point(90, 410);
			this.lblDefaultBrushEntity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblDefaultBrushEntity.Name = "lblDefaultBrushEntity";
			this.lblDefaultBrushEntity.Size = new System.Drawing.Size(224, 38);
			this.lblDefaultBrushEntity.TabIndex = 30;
			this.lblDefaultBrushEntity.Text = "Default Brush Entity";
			this.lblDefaultBrushEntity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkOverrideMapSize
			// 
			this.chkOverrideMapSize.Checked = true;
			this.chkOverrideMapSize.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkOverrideMapSize.Location = new System.Drawing.Point(34, 456);
			this.chkOverrideMapSize.Margin = new System.Windows.Forms.Padding(6);
			this.chkOverrideMapSize.Name = "chkOverrideMapSize";
			this.chkOverrideMapSize.Size = new System.Drawing.Size(274, 46);
			this.chkOverrideMapSize.TabIndex = 41;
			this.chkOverrideMapSize.Text = "Override FGD map size";
			this.chkOverrideMapSize.UseVisualStyleBackColor = true;
			// 
			// btnAddFgd
			// 
			this.btnAddFgd.Location = new System.Drawing.Point(738, 37);
			this.btnAddFgd.Margin = new System.Windows.Forms.Padding(6);
			this.btnAddFgd.Name = "btnAddFgd";
			this.btnAddFgd.Size = new System.Drawing.Size(148, 44);
			this.btnAddFgd.TabIndex = 27;
			this.btnAddFgd.Text = "Add...";
			this.btnAddFgd.UseVisualStyleBackColor = true;
			this.btnAddFgd.Click += new System.EventHandler(this.BrowseFgd);
			// 
			// lblMapSizeOverrideLow
			// 
			this.lblMapSizeOverrideLow.Location = new System.Drawing.Point(320, 458);
			this.lblMapSizeOverrideLow.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblMapSizeOverrideLow.Name = "lblMapSizeOverrideLow";
			this.lblMapSizeOverrideLow.Size = new System.Drawing.Size(70, 38);
			this.lblMapSizeOverrideLow.TabIndex = 40;
			this.lblMapSizeOverrideLow.Text = "Low";
			this.lblMapSizeOverrideLow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FGDSelector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.grpFgds);
			this.Name = "FGDSelector";
			this.Size = new System.Drawing.Size(928, 596);
			this.grpFgds.ResumeLayout(false);
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.ListView lstFgds;
		private System.Windows.Forms.ColumnHeader colFgdName;
		private System.Windows.Forms.ColumnHeader colFgdPath;
		private System.Windows.Forms.GroupBox grpFgds;
		private System.Windows.Forms.ComboBox cmbDefaultPointEntity;
		private System.Windows.Forms.ComboBox cmbDefaultBrushEntity;
		private System.Windows.Forms.ComboBox cmbMapSizeOverrideHigh;
		private System.Windows.Forms.Label lblDefaultPointEntity;
		private System.Windows.Forms.Label lblMapSizeOverrideHigh;
		private System.Windows.Forms.Button btnRemoveFgd;
		private System.Windows.Forms.ComboBox cmbMapSizeOverrideLow;
		private System.Windows.Forms.Label lblDefaultBrushEntity;
		private System.Windows.Forms.CheckBox chkOverrideMapSize;
		private System.Windows.Forms.Button btnAddFgd;
		private System.Windows.Forms.Label lblMapSizeOverrideLow;
		}
	}
