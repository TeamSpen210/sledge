using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Sledge.Common.Translations;
using Sledge.DataStructures.GameData;
using Sledge.Providers.GameData;

namespace Sledge.BspEditor.Environment.Controls
{
	/// <summary>
	/// Common control for selecting which FGD files are used for a given environment.
	/// </summary>
	public partial class FGDSelector : UserControl
	{
		public FGDSelector()
		{
			InitializeComponent();

			cmbDefaultPointEntity.SelectedIndexChanged += OnChanged;
			cmbDefaultBrushEntity.SelectedIndexChanged += OnChanged;
			chkOverrideMapSize.CheckedChanged += OnChanged;
			cmbMapSizeOverrideLow.SelectedIndexChanged += OnChanged;
			cmbMapSizeOverrideHigh.SelectedIndexChanged += OnChanged;
		}

		public EventHandler OnChanged;
		private IGameDataProvider _fgdProvider;

		public string FgdFilesLabel { get; set; } = "Forge Game Data files";

		/// <summary>
		/// Set the FGD provider to use for this control.
		/// </summary>
		/// <param name="provider"></param>
		public void SetProvider(IGameDataProvider provider)
		{
			_fgdProvider = provider;
		}

		public string defaultPointEntity
		{
			get => Convert.ToString(cmbDefaultPointEntity.SelectedItem, CultureInfo.InvariantCulture);
			set => cmbDefaultPointEntity.SelectedItem = value;
		}

		public string defaultBrushEntity
			{
			get => Convert.ToString(cmbDefaultBrushEntity.SelectedItem, CultureInfo.InvariantCulture);
			set => cmbDefaultBrushEntity.SelectedItem = value;
		}

		public bool overrideMapSize
		{
			get => chkOverrideMapSize.Checked;
			set => chkOverrideMapSize.Checked = value;
		}

		public decimal mapSizeOverrideLow
		{
			get => decimal.TryParse(Convert.ToString(cmbMapSizeOverrideLow.SelectedItem, CultureInfo.InvariantCulture), out decimal l) ? l : 0;
			set => cmbMapSizeOverrideLow.SelectedItem = Convert.ToString(value, CultureInfo.InvariantCulture);
		}

		public decimal mapSizeOverrideHigh
		{
			get => decimal.TryParse(Convert.ToString(cmbMapSizeOverrideHigh.SelectedItem, CultureInfo.InvariantCulture), out decimal h) ? h : 0;
			set => cmbMapSizeOverrideHigh.SelectedItem = Convert.ToString(value, CultureInfo.InvariantCulture);
		}

		public List<string> fileList
		{
			get => lstFgds.Items.OfType<ListViewItem>().Select(x => x.SubItems[1].Text).Where(File.Exists).ToList();
			set
			{
				lstFgds.Items.Clear();
				foreach (var fileName in value)
				{
					lstFgds.Items.Add(new ListViewItem(new[] { Path.GetFileName(fileName), fileName }) {ToolTipText = fileName});
				}
				UpdateFgdList();
			}
		}

		public void Translate(ITranslationStringProvider strings)
		{
			var prefix = this.GetType().FullName;
			btnAddFgd.Text = strings.GetString(prefix, "Add");
			btnRemoveFgd.Text = strings.GetString(prefix, "Remove");

			colFgdName.Text = strings.GetString(prefix, "Name");
			colFgdPath.Text = strings.GetString(prefix, "Path");

			lblDefaultPointEntity.Text = strings.GetString(prefix, "DefaultPointEntity");
			lblDefaultBrushEntity.Text = strings.GetString(prefix, "DefaultBrushEntity");
			lblMapSizeOverrideLow.Text = strings.GetString(prefix, "Low");
			lblMapSizeOverrideHigh.Text = strings.GetString(prefix, "High");
			chkOverrideMapSize.Text = strings.GetString(prefix, "OverrideMapSize");
		}

		private void BrowseFgd(object sender, EventArgs e)
		{
			using (var ofd = new OpenFileDialog {Filter = FgdFilesLabel + @" (*.fgd)|*.fgd", Multiselect = true})
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					foreach (var fileName in ofd.FileNames)
					{
						lstFgds.Items.Add(new ListViewItem(new[]
							{
							Path.GetFileName(fileName),
							fileName
							}) {ToolTipText = fileName});
					}
					UpdateFgdList();
					OnChanged(this, EventArgs.Empty);
				}
			}
		}

		private void RemoveFgd(object sender, EventArgs e)
		{
			if (lstFgds.SelectedItems.Count > 0)
			{
				foreach (var i in lstFgds.SelectedItems.OfType<ListViewItem>().ToList())
				{
					lstFgds.Items.Remove(i);
				}
				UpdateFgdList();
				OnChanged(this, EventArgs.Empty);
			}
		}

		private void UpdateFgdList()
		{
			lstFgds.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

			var entities = new List<GameDataObject>();
			if (_fgdProvider != null)
			{
				var files = lstFgds.Items.OfType<ListViewItem>().Select(x => x.SubItems[1].Text).Where(File.Exists)
					.Where(_fgdProvider.IsValidForFile);
				try
				{
					var gd = _fgdProvider.GetGameDataFromFiles(files);
					entities.AddRange(gd.Classes);
				}
				catch
				{
					//
				}
			}

			var selPoint = cmbDefaultPointEntity.SelectedItem as string;
			var selBrush = cmbDefaultBrushEntity.SelectedItem as string;

			cmbDefaultPointEntity.BeginUpdate();
			cmbDefaultBrushEntity.BeginUpdate();

			cmbDefaultPointEntity.Items.Clear();
			cmbDefaultBrushEntity.Items.Clear();

			cmbDefaultPointEntity.Items.Add("");
			cmbDefaultBrushEntity.Items.Add("");

			foreach (var gdo in entities.OrderBy(x => x.Name, StringComparer.InvariantCultureIgnoreCase))
			{
				if (gdo.ClassType == ClassType.Solid) cmbDefaultBrushEntity.Items.Add(gdo.Name);
				else if (gdo.ClassType != ClassType.Base) cmbDefaultPointEntity.Items.Add(gdo.Name);
			}

			var idx = cmbDefaultBrushEntity.Items.IndexOf(selBrush ?? "");
			if (idx >= 0) cmbDefaultBrushEntity.SelectedIndex = idx;
			idx = cmbDefaultPointEntity.Items.IndexOf(selPoint ?? "");
			if (idx >= 0) cmbDefaultPointEntity.SelectedIndex = idx;

			cmbDefaultPointEntity.EndUpdate();
			cmbDefaultBrushEntity.EndUpdate();
		}
	}
}
