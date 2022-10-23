using UnityEngine;

public class ShipDirectionalForceVolume : ForceVolume
{
	[SerializeField]
	private Vector3 _fieldDirection;
	[SerializeField]
	private float _fieldMagnitude;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawLine(base.transform.position, base.transform.position + base.transform.TransformDirection(_fieldDirection.normalized * _fieldMagnitude));
		Gizmos.color = Color.cyan;
	}
}
