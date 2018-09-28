using System;
using System.IO;
using System.Windows.Forms;
using Sledge.Common.Translations;
using Sledge.Providers.GameData;

namespace Sledge.BspEditor.Environment.Source
{
	public partial class SourceEnvironmentEditor : UserControl, IEnvironmentEditor
	{
		public Control Control => this;
		public event EventHandler EnvironmentChanged;
		private readonly IGameDataProvider _fgdProvider = Common.Container.Get<IGameDataProvider>("Fgd");

		public IEnvironment Environment
		{
			get => GetEnvironment();
			set { SetEnvironment(value as SourceEnvironment); }
		}

		public SourceEnvironmentEditor()
		{
			InitializeComponent();
		}

		public void Translate(ITranslationStringProvider strings)
		{
			CreateHandle();
			var prefix = GetType().FullName;

			grpDirectories.Text = strings.GetString(prefix, "Directories");
			lblGameinfo.Text = strings.GetString(prefix, "GameInfo");
		}


		private void SetEnvironment(SourceEnvironment env)
		{
			if (env == null) env = new SourceEnvironment();
		}

		private SourceEnvironment GetEnvironment()
		{
			return new SourceEnvironment(
			);
		}

		private void BrowseGameDirectory(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				if (Directory.Exists(txtGameDir.Text)) fbd.SelectedPath = txtGameDir.Text;
				if (fbd.ShowDialog() == DialogResult.OK)
				{
					txtGameDir.Text = fbd.SelectedPath;
				}
			}
		}
	}
}