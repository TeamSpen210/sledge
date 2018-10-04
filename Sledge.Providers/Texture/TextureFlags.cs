using System;

namespace Sledge.Providers.Texture
{
	/// <summary>
	/// Defines 
	/// </summary>
	[Flags]
	public enum TextureFlags : uint
	{
		None = 0,
		Transparent = 1u << 1, // The material is non-opaque.

		// Various special texture types.
		Nodraw = 1u << 2, // %compilenodraw
		Null = Nodraw, // name = "null", equivalent to Nodraw
		Trigger = 1u << 3, // %compiletrigger or name = "aaatrigger".
		Skybox = 1u << 4, // %compilesybox
		Water = 1u << 5,  // %compilewater or name[0] = "!".
		Origin = 1u << 6, // %compileorigin or name = "origin".
		Bevel = 1u << 7, // name = "bevel"
		Hint = 1u << 8, // %compilehint, or name = "hint".
		Skip = 1u << 9, // %compileskip, or name = "skip"
	}
}
