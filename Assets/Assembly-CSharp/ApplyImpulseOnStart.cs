using UnityEngine;

[RequireComponent(typeof(OWRigidbody))]
public class ApplyImpulseOnStart : MonoBehaviour
{
	[SerializeField]
	private float _timeToImpulse;
	[SerializeField]
	private Vector3 _impulse;
}
