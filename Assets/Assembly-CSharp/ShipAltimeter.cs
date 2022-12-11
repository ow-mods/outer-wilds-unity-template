using UnityEngine;

public class ShipAltimeter : MonoBehaviour
{
	[SerializeField]
	private Transform _raycastOrigin;
	[SerializeField]
	private float _shipRadius;
	[Space(10f)]
	[SerializeField]
	private float _barLength = 1f;
	[SerializeField]
	private Transform _shipIcon;
	[SerializeField]
	private Transform _groundBar;
	[SerializeField]
	private DampedSpring _groundBarSpring = new DampedSpring();

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject) && _raycastOrigin != null)
		{
			Gizmos.color = new Color(0.5f, 0.5f, 1f, 1f);
			Gizmos.DrawWireSphere(_raycastOrigin.position, _shipRadius);
		}
	}
}
