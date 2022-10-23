using UnityEngine;

public class FloodToggle : MonoBehaviour
{
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private GameObject[] _targets = new GameObject[0];
	[SerializeField]
	private OWTriggerVolume[] _volumes = new OWTriggerVolume[0];
	[SerializeField]
	private bool _deactivateOnFlood = true;
	[SerializeField]
	private bool _toggleActiveOnAwake;
}
