using System;
using UnityEngine;

public class FragmentSurfaceProxy : MonoBehaviour
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private float _innerRadius = 400f;
	[SerializeField]
	private float _outerRadius = 500f;
	[SerializeField]
	private float _northConeDegrees;
	[SerializeField]
	private float _southConeDegrees;

	private void OnDrawGizmosSelected()
	{
		if (!OWGizmos.IsDirectlySelected(base.gameObject)) return;
		Gizmos.color = new Color(1f, 0f, 1f, 1f);
		Gizmos.DrawWireSphere(base.transform.position, _innerRadius);
		Gizmos.DrawWireSphere(base.transform.position, _outerRadius);
		float cos = _outerRadius * Mathf.Cos(_northConeDegrees * ((float)Math.PI / 180f));
		float radius = _outerRadius * Mathf.Sin(_northConeDegrees * ((float)Math.PI / 180f));
		OWGizmos.DrawWireCircle(base.transform.position + base.transform.up * cos, base.transform.up, radius);
		float cos2 = _outerRadius * Mathf.Cos(_southConeDegrees * ((float)Math.PI / 180f));
		float radius2 = _outerRadius * Mathf.Sin(_southConeDegrees * ((float)Math.PI / 180f));
		OWGizmos.DrawWireCircle(base.transform.position + -base.transform.up * cos2, -base.transform.up, radius2);
	}
}
