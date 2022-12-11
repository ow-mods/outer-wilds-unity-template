using UnityEngine;

public class ShipDetachableModule : ShipModule
{
	[SerializeField]
	private float _mass = 0.1f;
	[SerializeField]
	private Vector3 _localCenterOfMass = Vector3.zero;
	[SerializeField]
	private Vector3 _detectorCenter = Vector3.zero;
	[SerializeField]
	private float _detectorRadius = 2f;
	[SerializeField]
	private GameObject _impactAudioPrefab;
	[SerializeField]
	private ShipLODTrigger _moduleLODTrigger;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Gizmos.color = Color.red;
			Gizmos.DrawSphere(_localCenterOfMass, 0.25f);
		}
	}
}
