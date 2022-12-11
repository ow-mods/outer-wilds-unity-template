using UnityEngine;

public class RetroZoomWarp : MonoBehaviour
{
	[SerializeField]
	private float _arrivalDistance = 5f;
	[SerializeField]
	private PlayerAttachPoint _attachPoint;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(base.transform.position, _arrivalDistance);
	}
}
