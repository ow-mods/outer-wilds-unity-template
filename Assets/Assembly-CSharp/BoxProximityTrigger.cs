using UnityEngine;

public class BoxProximityTrigger : ProximityTrigger
{
	[SerializeField]
	private Vector3 _size;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = new Color(0f, 1f, 0f, 0.5f);
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Gizmos.DrawCube(Vector3.zero, _size);
		}
		else
		{
			Gizmos.color = Color.green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Gizmos.DrawWireCube(Vector3.zero, _size);
		}
	}
}
