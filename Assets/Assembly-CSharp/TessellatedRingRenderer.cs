using UnityEngine;

public class TessellatedRingRenderer : TessellatedRenderer
{
	[Space]
	[SerializeField]
	[Range(0f, 1f)]
	private float _thickness;
	
	private void OnDrawGizmos()
	{
		Gizmos.color = Color.clear;
		Gizmos.matrix = base.transform.localToWorldMatrix;
		OWGizmos.DrawCylinder(Vector3.zero, Quaternion.identity, -2f, -1f);
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = (OWGizmos.IsDirectlySelected(base.gameObject) ? new Color(1f, 1f, 1f, 1f) : new Color(1f, 1f, 1f, 0.25f));
		Gizmos.matrix = base.transform.localToWorldMatrix;
		OWGizmos.DrawWireCylinder(Vector3.zero, Quaternion.AngleAxis(45f, Vector3.up), 2.002f, 1f);
		if (_thickness > 0f)
		{
			OWGizmos.DrawWireCylinder(Vector3.zero, Quaternion.AngleAxis(45f, Vector3.up), 2.002f, 1f - _thickness);
		}
	}
}
