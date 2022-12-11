using UnityEngine;

[ExecuteInEditMode]
public class TessellatedSphereRenderer : TessellatedRenderer
{
	private void OnDrawGizmos()
	{
		Gizmos.color = Color.clear;
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawSphere(Vector3.zero, 1f);
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = (OWGizmos.IsDirectlySelected(base.gameObject) ? new Color(1f, 1f, 1f, 1f) : new Color(1f, 1f, 1f, 0.25f));
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireSphere(Vector3.zero, 1.002f);
	}
}
