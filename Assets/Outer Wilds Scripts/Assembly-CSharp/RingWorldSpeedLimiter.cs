using UnityEngine;

[RequireComponent(typeof(OWTriggerVolume))]
public class RingWorldSpeedLimiter : MonoBehaviour
{
	[SerializeField]
	private float _maxSpeed;
	[SerializeField]
	private float _stoppingDistance = 100f;
	[SerializeField]
	private float _maxEntryAngle = 60f;
}
