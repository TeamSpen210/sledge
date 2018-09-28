using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sledge.BspEditor.Compile;
using Sledge.BspEditor.Documents;
using Sledge.BspEditor.Primitives.MapData;
using Sledge.DataStructures.GameData;
using Sledge.FileSystem;

namespace Sledge.BspEditor.Environment.Source
{
	internal class SourceEnvironment : IEnvironment
	{
		private readonly Lazy<Task<TextureCollection>> _textureCollection;
		public string Engine => "Source";
		public string ID { get; set; }
		public string Name { get; set; }
		public string DefaultPointEntity { get; set; }
		public string DefaultBrushEntity { get; set; }
		public decimal DefaultTextureScale { get; set; }

		public string GameinfoPath { get; set; }

		public SourceEnvironment()
		{
			_textureCollection = new Lazy<Task<TextureCollection>>(MakeTextureCollectionAsync);
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
			throw new NotImplementedException();
		}

		public Task<TextureCollection> GetTextureCollection()
		{
			return _textureCollection.Value;
		}

		public Task<GameData> GetGameData()
		{
			throw new NotImplementedException();
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

		public IEnumerable<AutomaticVisgroup> GetAutomaticVisgroups()
		{
			throw new NotImplementedException();
		}

	}
}