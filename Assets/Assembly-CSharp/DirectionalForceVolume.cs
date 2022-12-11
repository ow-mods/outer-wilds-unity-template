using UnityEngine;

public class DirectionalForceVolume : ForceVolume
{
	[SerializeField]
	private Vector3 _fieldDirection;
	[SerializeField]
	private float _fieldMagnitude;
	[SerializeField]
	private bool _affectsAlignment = true;
	[SerializeField]
	private bool _offsetCentripetalForce;
	[SerializeField]
	private bool _playGravityCrystalAudio;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = Color.red;
			Gizmos.DrawLine(base.transform.position, base.transform.position + base.transform.TransformDirection(_fieldDirection * _fieldMagnitude));
			Gizmos.color = Color.cyan;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			if (GetComponent<BoxCollider>() != null)
			{
				Gizmos.DrawWireCube(Vector3.zero + GetComponent<BoxCollider>().center, GetComponent<BoxCollider>().size);
			}
			else if (GetComponent<SphereCollider>() != null)
			{
				Gizmos.DrawWireSphere(Vector3.zero + GetComponent<SphereCollider>().center, GetComponent<SphereCollider>().radius);
			}
		}
	}
}
