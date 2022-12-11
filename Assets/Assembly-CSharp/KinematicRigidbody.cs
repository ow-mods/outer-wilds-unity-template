using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class KinematicRigidbody : MonoBehaviour
{
	[SerializeField]
	private Shape _inertiaApproximationShape;

	public Vector3 worldCenterOfMass
	{
		get
		{
			var rigidbody = GetComponent<Rigidbody>();
			return rigidbody != null ? rigidbody.position : base.transform.position;
		}
		set
		{
			Debug.LogWarning("Tried to set the center of mass of a KinematicRigidbody; will always be (0,0,0)", this);
		}
	}
}
