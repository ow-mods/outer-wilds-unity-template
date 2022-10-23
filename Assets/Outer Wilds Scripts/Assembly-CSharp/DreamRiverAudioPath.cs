using UnityEngine;

public class DreamRiverAudioPath : BaseRiverAudioPath
{
	[SerializeField]
	private float _minX;
	[SerializeField]
	private float _maxX;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			DrawPath(_baseFloodTriangles);
		}
	}
}
