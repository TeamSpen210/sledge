using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Sledge.BspEditor.Compile;
using Sledge.BspEditor.Documents;
using Sledge.BspEditor.Environment.Goldsource;
using Sledge.BspEditor.Primitives.MapData;
using Sledge.BspEditor.Primitives.MapObjects;
using Sledge.Common;
using Sledge.Common.Transport;
using Sledge.DataStructures.GameData;
using Sledge.FileSystem;
using Sledge.Providers.GameData;

namespace Sledge.BspEditor.Environment.Source
{
	internal class SourceEnvironment : IEnvironment
	{
		private readonly Lazy<Task<TextureCollection>> _textureCollection;
		private readonly Lazy<Task<GameData>> _gameData;
		private readonly IGameDataProvider _fgdProvider;
		private static readonly SerialisedObjectFormatter _formatter = new SerialisedObjectFormatter();

		public string Engine => "Source";
		public string ID { get; set; }
		public string Name { get; set; }
		public string DefaultPointEntity { get; set; }
		public string DefaultBrushEntity { get; set; }
		public decimal DefaultTextureScale { get; set; } = 0.25m;
		public bool OverrideMapSize { get; set; } = false;
		public decimal MapSizeLow { get; set; } = -16384;
		public decimal MapSizeHigh { get; set; } = 16384;
		public List<string> FgdFiles { get; set; }

		private SerialisedObject _gameInfo;
		private string _gameInfoPath;

		public string GameinfoPath
		{
			get => _gameInfoPath;
			set
			{
				_gameInfoPath = value;
				_gameInfo = null;
			}
		}

		public SourceEnvironment()
		{
			_fgdProvider = Container.Get<IGameDataProvider>("Fgd");
			_textureCollection = new Lazy<Task<TextureCollection>>(MakeTextureCollectionAsync);
			_gameData = new Lazy<Task<GameData>>(MakeGameDataAsync);
		}

		public IFile Root
		{
			get { throw new NotImplementedException(); }
		}

		public IEnumerable<string> Directories
		{
			get { throw new NotImplementedException(); }
		}

		private async Task<TextureCollection> MakeTextureCollectionAsync()
		{
			SerialisedObject ginfo = GetGameInfo();
			ginfo.Get("SearchPaths");
		}

		private Task<GameData> MakeGameDataAsync()
		{
			return Task.FromResult(_fgdProvider.GetGameDataFromFiles(FgdFiles));
		}

		public Task<TextureCollection> GetTextureCollection()
		{
			return _textureCollection.Value;
		}

		public Task<GameData> GetGameData()
		{
			return _gameData.Value;
		}

		private SerialisedObject GetGameInfo()
		{
			if (_gameInfo == null)
			{
				using (var file = File.Open(_gameInfoPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					_gameInfo = _formatter.Deserialize(file).First();
				}
			}
			return _gameInfo;
		}

		public Task UpdateDocumentData(MapDocument document)
		{
			throw new NotImplementedException();
		}

		public void AddData(IEnvironmentData data)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<T> GetData<T>() where T : IEnvironmentData
		{
			throw new NotImplementedException();
		}

		public Task<Batch> CreateBatch(IEnumerable<BatchArgument> arguments, BatchOptions options)
		{
			throw new NotImplementedException();
		}

		private static readonly string AutoVisgroupPrefix = typeof(GoldsourceEnvironment).Namespace + ".AutomaticVisgroups";

		public IEnumerable<AutomaticVisgroup> GetAutomaticVisgroups()
		{
			// Entities
			yield return new AutomaticVisgroup(x => x is Entity && x.Hierarchy.HasChildren)
			{
				Path = $"{AutoVisgroupPrefix}.Entities",
				Key = $"{AutoVisgroupPrefix}.BrushEntities"
			};
			yield return new AutomaticVisgroup(x => x is Entity && !x.Hierarchy.HasChildren)
			{
				Path = $"{AutoVisgroupPrefix}.Entities",
				Key = $"{AutoVisgroupPrefix}.PointEntities"
			};
			yield return new AutomaticVisgroup(x => x is Entity e && e.EntityData.Name.StartsWith("light", StringComparison.InvariantCultureIgnoreCase))
			{
				Path = $"{AutoVisgroupPrefix}.Entities",
				Key = $"{AutoVisgroupPrefix}.Lights"
			};
			yield return new AutomaticVisgroup(x => x is Entity e && e.EntityData.Name.StartsWith("trigger_", StringComparison.InvariantCultureIgnoreCase))
			{
				Path = $"{AutoVisgroupPrefix}.Entities",
				Key = $"{AutoVisgroupPrefix}.Triggers"
			};
			yield return new AutomaticVisgroup(x => x is Entity e && e.EntityData.Name.IndexOf("_node", StringComparison.InvariantCultureIgnoreCase) >= 0)
			{
				Path = $"{AutoVisgroupPrefix}.Entities",
				Key = $"{AutoVisgroupPrefix}.Nodes"
			};

			// Brushes need to parse the VMT data.
		}
	}
}