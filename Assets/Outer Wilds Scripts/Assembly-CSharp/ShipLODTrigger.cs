using UnityEngine;

public class ShipLODTrigger : MonoBehaviour
{
	[SerializeField]
	private float _radius = 10f;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = new Color(0f, 1f, 0f, 0.5f);
			Gizmos.DrawSphere(base.transform.position, _radius);
		}
	}
}
