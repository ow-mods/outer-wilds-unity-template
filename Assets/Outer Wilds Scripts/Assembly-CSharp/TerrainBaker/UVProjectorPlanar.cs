using UnityEngine;

namespace TerrainBaker
{
	public class UVProjectorPlanar : UVProjector
	{
		public enum Plane
		{
			X = 0,
			Y = 1,
			Z = 2,
		}

		[SerializeField]
		protected Plane _plane = Plane.Z;
		[SerializeField]
		protected Vector2 _scale = Vector2.one;
	}
}
