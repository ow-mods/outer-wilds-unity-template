using UnityEngine;

[RequireComponent(typeof(OWRigidbody))]
public class RandomAngularVelocity : MonoBehaviour
{
	[SerializeField]
	private float _minSpeed;
	[SerializeField]
	private float _maxSpeed;
}
