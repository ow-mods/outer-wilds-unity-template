using UnityEngine;

namespace TerrainBaker
{
	public class UVProjectorCylindrical : UVProjector
	{
		[SerializeField]
		protected float _height = 1f;
		[SerializeField]
		protected float _arc = 90f;
	}
}
