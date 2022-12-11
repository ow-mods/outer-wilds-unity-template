using UnityEngine;

public class BuildingRailController : MonoBehaviour
{
	[SerializeField]
	private Sector _sector;
	[Space]
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private DetachableBuilding _detachableBuilding;
	[SerializeField]
	private Animation _animation;
	[SerializeField]
	private float _delay;
}
