using UnityEngine;

[RequireComponent(typeof(OWRigidbody))]
public class InitialVelocity : MonoBehaviour
{
	[SerializeField]
	private Vector3 initVelocityDirection;
	[SerializeField]
	private float initVelocityMagnitude;
	[SerializeField]
	private Vector3 initAngularVelocityAxis;
	[SerializeField]
	private float initAngularVelocityMagnitude;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawLine(base.transform.position, base.transform.position + initVelocityDirection.normalized * initVelocityMagnitude * 50f);
		Gizmos.color = Color.green;
		Gizmos.DrawLine(base.transform.position, base.transform.position + initAngularVelocityAxis.normalized * initAngularVelocityMagnitude * 2000f);
	}
}
