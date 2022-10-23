using UnityEngine;

public class OceanChopZone : MonoBehaviour
{
	[SerializeField]
	private OceanEffectController _ocean;
	[SerializeField]
	private float _radius = 10f;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Gizmos.DrawWireSphere(Vector3.zero, _radius);
		}
	}
}
