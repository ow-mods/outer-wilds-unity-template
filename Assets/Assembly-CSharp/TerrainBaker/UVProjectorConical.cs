using UnityEngine;

namespace TerrainBaker
{
	public class UVProjectorConical : UVProjector
	{
		[SerializeField]
		protected float _bottomHeight;
		[SerializeField]
		protected float _topHeight = 1f;
		[SerializeField]
		protected float _arc = 90f;
	}
}
