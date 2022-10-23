using UnityEngine;

public class OWCapsuleCollider : OWCustomCollider
{
	[SerializeField]
	private bool _useTopCap = true;
	[SerializeField]
	private bool _useBottomCap = true;
	[SerializeField]
	private bool _drawWireframe;

	private void OnDrawGizmos()
	{
		if (_drawWireframe && OWGizmos.SelectionContainsComponentOfType<OWCapsuleCollider>())
		{
			var capsule = GetComponent<CapsuleCollider>();
			float num = Mathf.Max(0f, capsule.height * 0.5f - capsule.radius);
			Vector3 vector = base.transform.TransformPoint(capsule.center + Vector3.up * num);
			Vector3 vector2 = base.transform.TransformPoint(capsule.center - Vector3.up * num);
			Gizmos.color = Color.green;
			OWGizmos.DrawWireCircle(vector, base.transform.up, capsule.radius);
			OWGizmos.DrawWireCircle(vector2, base.transform.up, capsule.radius);
			Gizmos.DrawLine(vector2 + base.transform.right * capsule.radius, vector + base.transform.right * capsule.radius);
			Gizmos.DrawLine(vector2 + -base.transform.right * capsule.radius, vector + -base.transform.right * capsule.radius);
			Gizmos.DrawLine(vector2 + base.transform.forward * capsule.radius, vector + base.transform.forward * capsule.radius);
			Gizmos.DrawLine(vector2 + -base.transform.forward * capsule.radius, vector + -base.transform.forward * capsule.radius);
			if (_useTopCap)
			{
				OWGizmos.DrawWireArc(vector, base.transform.right, -base.transform.forward, 180f, capsule.radius);
				OWGizmos.DrawWireArc(vector, base.transform.forward, base.transform.right, 180f, capsule.radius);
			}
			if (_useBottomCap)
			{
				OWGizmos.DrawWireArc(vector2, base.transform.right, base.transform.forward, 180f, capsule.radius);
				OWGizmos.DrawWireArc(vector2, base.transform.forward, -base.transform.right, 180f, capsule.radius);
			}
		}
	}
}
