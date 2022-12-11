using UnityEngine;

public class QuantumSkeletonTower : QuantumObject
{
	[SerializeField]
	private GameObject[] _towerSkeletons;
	[SerializeField]
	private GameObject[] _towerTrackerObjects;
	[SerializeField]
	private VisibilityObject[] _pointingSkeletons;
	[SerializeField]
	private EyeShuttleController _shuttleController;
	[SerializeField]
	private float _minPlayerOffset;
	[SerializeField]
	private float _maxPlayerOffset;
	[SerializeField]
	private bool _drawOffsets;

	private void OnDrawGizmos()
	{
		if (_drawOffsets)
		{
			Gizmos.color = Color.yellow;
			OWGizmos.DrawWireCircle(base.transform.position, base.transform.up, _minPlayerOffset);
			OWGizmos.DrawWireCircle(base.transform.position, base.transform.up, _maxPlayerOffset);
		}
	}
}
