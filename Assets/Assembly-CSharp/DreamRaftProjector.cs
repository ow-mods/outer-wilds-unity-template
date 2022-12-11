using UnityEngine;

public class DreamRaftProjector : DreamObjectProjector
{
	[Space]
	[SerializeField]
	private Transform _raftSpawn;
	[SerializeField]
	private SphereBounds _visibilityBounds = new SphereBounds(Vector3.zero, 0.5f);

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.matrix = Matrix4x4.TRS(base.transform.position, base.transform.rotation, Vector3.one);
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireSphere(_visibilityBounds.center, _visibilityBounds.radius);
		}
	}
}
