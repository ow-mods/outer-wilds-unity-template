using UnityEngine;

public class TessellatedPlaneRenderer : TessellatedRenderer
{
	[Space]
	[SerializeField]
	private int _tileCountX = 1;
	[SerializeField]
	private int _tileCountY = 1;
	[SerializeField]
	private float _thickness;

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.clear;
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawCube(Vector3.zero, new Vector3(2f, 0f, 2f));
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = (OWGizmos.IsDirectlySelected(base.gameObject) ? new Color(1f, 1f, 1f, 1f) : new Color(1f, 1f, 1f, 0.25f));
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.DrawWireCube(Vector3.zero, new Vector3(2f, 0f, 2f));
		if (_thickness > 0f)
		{
			Color color = Gizmos.color;
			Gizmos.color = new Color(color.r, color.g, color.b, color.a * 0.125f);
			float num = _thickness / base.transform.lossyScale.y * 0.5f;
			Gizmos.DrawWireCube(new Vector3(0f, num, 0f), new Vector3(2f, 0f, 2f));
			Gizmos.DrawWireCube(new Vector3(0f, 0f - num, 0f), new Vector3(2f, 0f, 2f));
		}
	}
}
