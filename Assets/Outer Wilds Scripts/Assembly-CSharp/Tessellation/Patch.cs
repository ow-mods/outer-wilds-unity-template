namespace Tessellation
{
	public class Patch
	{
		public enum RenderMode
		{
			Planar,
			Cubic,
			Spherical,
			Cylindrical
		}
		
		public enum CullingMode
		{
			None = 0,
			Normal = 1,
			ShadowCasting = 2,
		}

	}
}
