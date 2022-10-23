using UnityEngine;

public class DetachOnFloodImpact : MonoBehaviour
{
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private DetachableBuilding _detachableBuilding;
	[Space]
	[SerializeField]
	private GameObject _detectorGameObject;
	[SerializeField]
	private Collider[] _preDetachColliders = new Collider[0];
	[SerializeField]
	private Collider[] _postDetachColliders = new Collider[0];
	[Space]
	[SerializeField]
	private SectorCullGroup _cullGroup;
	[SerializeField]
	private Sector _newCullSector;
	[SerializeField]
	private SectorCollisionGroup _collisionGroup;
	[SerializeField]
	private Sector _newCollisionSector;
}
