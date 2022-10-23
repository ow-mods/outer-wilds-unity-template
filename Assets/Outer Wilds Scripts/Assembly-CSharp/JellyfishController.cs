using UnityEngine;

[RequireComponent(typeof(OWRigidbody))]
public class JellyfishController : SectoredMonoBehaviour
{
	[SerializeField]
	private float _upperLimit = 400f;
	[SerializeField]
	private float _lowerLimit = 200f;
	[SerializeField]
	private float _upwardsAcceleration = 10f;
	[SerializeField]
	private float _downwardsAcceleration = 20f;
	[SerializeField]
	private FluidVolume _attractiveFluidVolume;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject) && base.transform.parent != null)
		{
			OWRigidbody oWRigidbody = base.transform.parent.GetComponentInParent<OWRigidbody>();
			if (oWRigidbody != null)
			{
				Vector3 position = oWRigidbody.transform.position;
				Vector3 vector = Vector3.Normalize(base.transform.position - position);
				Gizmos.color = Color.magenta;
				Gizmos.DrawLine(position + vector * _lowerLimit, position + vector * _upperLimit);
				Gizmos.DrawSphere(position + vector * _lowerLimit, 10f);
				Gizmos.DrawSphere(position + vector * _upperLimit, 10f);
			}
		}
	}
}
