using UnityEngine;

[RequireComponent(typeof(OWRigidbody))]
public class InitialMotion : MonoBehaviour
{
	[SerializeField]
	private OWRigidbody _primaryBody;
	[SerializeField]
	private float _orbitAngle;
	[SerializeField]
	private float _orbitImpulseScalar = 1f;
	[SerializeField]
	private Vector3 _rotationAxis = Vector3.up;
	[SerializeField]
	private bool _isGlobalAxis;
	[SerializeField]
	private float _initAngularSpeed;
	[SerializeField]
	private Vector3 _initLinearDirection = Vector3.forward;
	[SerializeField]
	private float _initLinearSpeed;
	[SerializeField]
	private bool _printAxes;
	[SerializeField]
	private bool _printVelocity;

	private void OnDrawGizmosSelected()
	{
		if (base.enabled && OWGizmos.IsDirectlySelected(base.gameObject))
		{
			var rigidbody = GetComponent<Rigidbody>();
			if (_primaryBody != null)
			{
				Vector3 vector = rigidbody.worldCenterOfMass - _primaryBody.GetComponent<Rigidbody>().worldCenterOfMass;
				Vector3 normalized = Vector3.Cross(vector, Vector3.up).normalized;
				normalized = Quaternion.AngleAxis(_orbitAngle, vector) * normalized;
				Gizmos.color = Color.red;
				Gizmos.DrawLine(rigidbody.worldCenterOfMass, rigidbody.worldCenterOfMass + normalized.normalized * 200f * Mathf.Sign(_orbitImpulseScalar));
			}
			if (_initLinearSpeed > 0f)
			{
				Gizmos.color = Color.red;
				Gizmos.DrawLine(rigidbody.worldCenterOfMass, rigidbody.worldCenterOfMass + base.transform.TransformDirection(_initLinearDirection).normalized * 200f);
			}
			Gizmos.color = Color.green;
			if (_isGlobalAxis)
			{
				Gizmos.DrawLine(rigidbody.worldCenterOfMass, rigidbody.worldCenterOfMass + _rotationAxis.normalized * _initAngularSpeed * 2000f);
			}
			else
			{
				Gizmos.DrawLine(rigidbody.worldCenterOfMass, rigidbody.worldCenterOfMass + base.transform.TransformDirection(_rotationAxis).normalized * _initAngularSpeed * 2000f);
			}
		}
	}
}
