using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class OWRigidbody : MonoBehaviour
{
	[SerializeField]
	private bool _kinematicSimulation;
	[SerializeField]
	private bool _autoGenerateCenterOfMass = true;
	[SerializeField]
	private Vector3 _centerOfMass = Vector3.zero;
	[SerializeField]
	private bool _isTargetable = true;
	[SerializeField]
	private bool _maintainOriginalCenterOfMass = true;
	[SerializeField]
	private Sector _simulateInSector;

	public Vector3 GetPosition()
	{
		return GetComponent<Rigidbody>().position;
	}
	
	public Vector3 GetWorldCenterOfMass()
	{
		var rigidbody = GetComponent<Rigidbody>();
		var kinematicRigidbody = GetComponent<KinematicRigidbody>();
		if (kinematicRigidbody != null && rigidbody.isKinematic && _kinematicSimulation)
			return kinematicRigidbody.worldCenterOfMass;
		else
			return rigidbody.worldCenterOfMass;
	}

	private void OnDrawGizmosSelected()
	{
		Vector3 center = ((!_autoGenerateCenterOfMass) ? base.transform.TransformPoint(_centerOfMass) : GetWorldCenterOfMass());
		Gizmos.color = Color.magenta;
		Gizmos.DrawSphere(center, 0.2f);
	}
}
