using UnityEngine;

[RequireComponent(typeof(OWRigidbody))]
public class HighSpeedImpactSensor : MonoBehaviour
{
	[SerializeField]
	private SectorDetector _sectorDetector;
	[Space]
	[SerializeField]
	private float _checkSpeedThreshold = 300f;
	[SerializeField]
	private Vector3 _localOffset = Vector3.zero;
	[SerializeField]
	private float _radius;
	[Header("New Method")]
	[SerializeField]
	private bool _verbose;
	[SerializeField]
	private ImpactSensor _impactSensor;
	[SerializeField]
	private Collider _collider;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere(base.transform.TransformPoint(_localOffset), _radius);
	}
}
