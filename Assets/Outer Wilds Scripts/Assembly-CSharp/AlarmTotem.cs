using UnityEngine;

public class AlarmTotem : SectoredMonoBehaviour
{
	[SerializeField]
	private Transform _sightOrigin;
	[SerializeField]
	private OWLightController _pulseLightController;
	[Space]
	[SerializeField]
	private float _sightDistance = 50f;
	[SerializeField]
	private float _sightAngle = 90f;
	[Space]
	[SerializeField]
	private Transform _leftFaceCover;
	[SerializeField]
	private Transform _rightFaceCover;
	[Header("Simulation")]
	[SerializeField]
	private Renderer _simTotemRenderer;
	[SerializeField]
	private Material _simAlarmMaterial;
	[SerializeField]
	private OWRenderer _simVisionConeRenderer;
	[SerializeField]
	[ColorUsage(false, true)]
	private Color _simAlarmColor;

	private void OnDrawGizmosSelected()
	{
		if (_sightOrigin == null) return;
		Quaternion quaternion = Quaternion.AngleAxis(_sightAngle * 0.5f, base.transform.up);
		Vector3 vector = quaternion * (base.transform.forward * _sightDistance);
		Vector3 vector2 = Quaternion.Inverse(quaternion) * (base.transform.forward * _sightDistance);
		Gizmos.color = Color.cyan;
		Gizmos.DrawLine(_sightOrigin.position, _sightOrigin.position + vector);
		Gizmos.DrawLine(_sightOrigin.position, _sightOrigin.position + vector2);
		Gizmos.color = Color.blue;
		OWGizmos.DrawWireCircle(_sightOrigin.position, base.transform.up, _sightDistance);
	}
}
