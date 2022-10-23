using UnityEngine;

public class FaceActiveCamera : MonoBehaviour
{
	[SerializeField]
	private Vector3 _localFacingVector = Vector3.forward;
	[SerializeField]
	private Vector3 _localRotationAxis = Vector3.zero;
	[SerializeField]
	private bool _useLookAt;
}
