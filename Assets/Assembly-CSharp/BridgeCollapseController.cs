using UnityEngine;

public class BridgeCollapseController : MonoBehaviour
{
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private GameObject[] _intactObjectRoots = new GameObject[0];
	[SerializeField]
	private GameObject[] _destroyedObjectRoots = new GameObject[0];
	[SerializeField]
	private OWRigidbody[] _fragments = new OWRigidbody[0];
	[SerializeField]
	private float _delay;
}
