using UnityEngine;

[RequireComponent(typeof(OWRigidbody))]
public class AnglerfishController : SectoredMonoBehaviour
{
	[SerializeField]
	private Vector3 _mouthOffset;
	[SerializeField]
	private float _acceleration = 2f;
	[SerializeField]
	private float _investigateSpeed = 20f;
	[SerializeField]
	private float _chaseSpeed = 42f;
	[SerializeField]
	private float _turnSpeed = 180f;
	[SerializeField]
	private float _quickTurnSpeed = 360f;
	[Space]
	[SerializeField]
	private float _arrivalDistance = 100f;
	[SerializeField]
	private float _pursueDistance = 200f;
	[SerializeField]
	private float _escapeDistance = 500f;
	[Space]
	[SerializeField]
	private float _consumeShipCrushDelay = 3f;
	[SerializeField]
	private float _consumeDeathDelay = 5f;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawWireSphere(base.transform.position, _arrivalDistance);
			Gizmos.color = Color.red;
			Gizmos.DrawWireSphere(base.transform.position, _pursueDistance);
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireSphere(base.transform.position, _escapeDistance);
			Gizmos.color = Color.green;
			Gizmos.DrawSphere(base.transform.position + base.transform.TransformDirection(_mouthOffset), 3f);
		}
	}
}
