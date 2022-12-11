using UnityEngine;
using UnityEngine.Serialization;

public class RingRiverAudioPath : BaseRiverAudioPath
{
	[SerializeField]
	private OWRingRiverCollider _ringRiverCollider;
	[HideInInspector]
	[SerializeField]
	protected BaseRiverAudioPath.Triangle[] _postFloodTriangles;
	[FormerlySerializedAs("_cachedPostFloodDegreeSections")]
	[HideInInspector]
	[SerializeField]
	protected float[] _cachedPostFloodTriangleSections;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			if (showPostFlood)
			{
				DrawPath(_postFloodTriangles);
			}
			else
			{
				DrawPath(_baseFloodTriangles);
			}
		}
	}
}
