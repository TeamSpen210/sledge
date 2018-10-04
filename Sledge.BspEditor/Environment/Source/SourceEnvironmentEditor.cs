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
		public string GameinfoFileLabel { get; set; } = "Location of GameInfo";

		public IEnvironment Environment
		{
			get => GetEnvironment();
			set { SetEnvironment(value as SourceEnvironment); }
		}

		public SourceEnvironmentEditor()
		{
			InitializeComponent();
			fgdSelector.SetProvider(_fgdProvider);
		}

		public void Translate(ITranslationStringProvider strings)
		{
			CreateHandle();
			var prefix = GetType().FullName;

			grpDirectories.Text = strings.GetString(prefix, "Directories");
			lblGameinfo.Text = strings.GetString(prefix, "GameInfo");
			GameinfoFileLabel = strings.GetString(prefix, "GameinfoTitle");
		}


		private void SetEnvironment(SourceEnvironment env)
		{
			if (env == null)
			{
				return;
			}

			txtGameInfo.Text = env.GameinfoPath;

			fgdSelector.fileList = env.FgdFiles;
			fgdSelector.defaultPointEntity = env.DefaultPointEntity;
			fgdSelector.defaultBrushEntity = env.DefaultBrushEntity;
			fgdSelector.overrideMapSize = env.OverrideMapSize;
			fgdSelector.mapSizeOverrideLow = env.MapSizeLow;
			fgdSelector.mapSizeOverrideHigh = env.MapSizeHigh;

			}

		private SourceEnvironment GetEnvironment()
		{
			return new SourceEnvironment
			{
				DefaultBrushEntity = fgdSelector.defaultBrushEntity,
				DefaultPointEntity = fgdSelector.defaultPointEntity,
				FgdFiles = fgdSelector.fileList,
				GameinfoPath = txtGameInfo.Text,
			};
		}

		private void BrowseGameInfo(object sender, EventArgs e)
		{
			using (var fbd = new OpenFileDialog())
			{
				fbd.Filter = GameinfoFileLabel + @" (*.txt)|*.txt";
				fbd.CheckFileExists = true;
				fbd.DereferenceLinks = true;
				fbd.DefaultExt = ".txt";
				if (File.Exists(txtGameInfo.Text)) fbd.FileName = txtGameInfo.Text;

				if (fbd.ShowDialog() == DialogResult.OK)
				{
					txtGameInfo.Text = fbd.FileName;
				}
			}
		}
	}
}
