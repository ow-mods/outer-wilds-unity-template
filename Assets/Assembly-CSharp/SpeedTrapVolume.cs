using UnityEngine;

[RequireComponent(typeof(OWTriggerVolume))]
public class SpeedTrapVolume : MonoBehaviour
{
	[SerializeField]
	private float _speedLimit = 10f;
	[SerializeField]
	private float _acceleration = 3f;
}
