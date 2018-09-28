using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sledge.Common.Translations;

namespace Sledge.BspEditor.Environment.Source
	{
	[Export(typeof(IEnvironmentFactory))]
	[AutoTranslate]
	class SourceEnvironmentFactory: IEnvironmentFactory
	{
		public Type Type => typeof(SourceEnvironment);
		public string TypeName => "SourceEnvironment";
		public string Description => "Source";

		private T GetVal<T>(Dictionary<string, string> dictionary, string key, T def = default(T))
		{
			if (dictionary.TryGetValue(key, out var val))
			{
				try
				{
					return (T)Convert.ChangeType(val, typeof(T), CultureInfo.InvariantCulture);
				}
				catch
				{
					//
				}
			}
			return def;
		}

		public IEnvironment Deserialise(SerialisedEnvironment environment)
		{
			return new SourceEnvironment()
			{
				ID = environment.ID,
				Name = environment.Name,
				DefaultPointEntity = GetVal(environment.Properties, "DefaultPointEntity", "prop_static"),
				DefaultBrushEntity = GetVal(environment.Properties, "DefaultBrushEntity", "func_detail"),
				DefaultTextureScale = GetVal(environment.Properties, "DefaultTextureScale", 0.25m),
				GameinfoPath = GetVal(environment.Properties, "GamePath", ""),
			};
		}

		public SerialisedEnvironment Serialise(IEnvironment environment)
		{
			var env = (SourceEnvironment) environment;
			return new SerialisedEnvironment()
			{
				ID = env.ID,
				Name = env.Name,
				Properties =
				{
					{ "DefaultPointEntity", env.DefaultPointEntity },
					{ "DefaultBrushEntity", env.DefaultBrushEntity },
					{ "DefaultTextureScale", Convert.ToString(env.DefaultTextureScale, CultureInfo.InvariantCulture) },
					{ "GamePath", env.GameinfoPath }
				}
			};
		}

		public IEnvironment CreateEnvironment()
		{
			return new SourceEnvironment();
		}

		public IEnvironmentEditor CreateEditor()
		{
			return new SourceEnvironmentEditor();
		}
	}
}
