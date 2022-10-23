using UnityEngine;

[RequireComponent(typeof(OWRigidbody))]
public class AngularAccelerator : MonoBehaviour
{
	[SerializeField]
	private Vector3 _rotationAxis = Vector3.up;
	[SerializeField]
	private float _angularAcceleration = 0.001f;
}
