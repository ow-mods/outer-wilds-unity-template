using UnityEngine;

public class ProxyShadowCasterSuperGroup : MonoBehaviour
{
	[SerializeField]
	private SphereBounds _bounds = new SphereBounds(Vector3.zero, 500f);

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = new Color(1f, 0f, 0f, 0.25f);
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Gizmos.DrawSphere(_bounds.center, _bounds.radius);
		}
	}
}
