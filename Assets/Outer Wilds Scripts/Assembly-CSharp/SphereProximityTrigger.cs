using UnityEngine;

public class SphereProximityTrigger : ProximityTrigger
{
	[SerializeField]
	private float _radius;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = new Color(0f, 1f, 0f, 0.5f);
			Gizmos.matrix = Matrix4x4.TRS(base.transform.position, base.transform.rotation, Vector3.one);
			Gizmos.DrawSphere(Vector3.zero, _radius);
		}
		else
		{
			Gizmos.color = Color.green;
			OWGizmos.DrawBillboardedWireCircle(base.transform.position, _radius);
		}
	}
}
