using UnityEngine;

public class GhostSensors : MonoBehaviour
{
	[SerializeField]
	private Transform _sightOrigin;
	[SerializeField]
	private DreamLanternController _lantern;
	[SerializeField]
	private LightSensor _lightSensor;
	[SerializeField]
	private OWTriggerVolume _contactTrigger;
	[SerializeField]
	private BoxShape _contactEdgeCatcherShape;
	[SerializeField]
	private Animator _animator;
	[Header("Grab Buffs")]
	[SerializeField]
	private float _grabDistanceBuff;
	[SerializeField]
	private float _grabAngleBuff;

	private void OnDrawGizmosSelected()
	{
		if (_sightOrigin == null) return;
		Gizmos.color = Color.blue;
		Quaternion quaternion = Quaternion.AngleAxis(20f, base.transform.up);
		Vector3 vector = quaternion * (base.transform.forward * 50f);
		Vector3 vector2 = Quaternion.Inverse(quaternion) * (base.transform.forward * 50f);
		Gizmos.DrawLine(_sightOrigin.position, _sightOrigin.position + vector);
		Gizmos.DrawLine(_sightOrigin.position, _sightOrigin.position + vector2);
		Gizmos.DrawLine(_sightOrigin.position + base.transform.right * 0.5f, _sightOrigin.position + base.transform.forward + base.transform.right * 0.5f);
		Gizmos.DrawLine(_sightOrigin.position - base.transform.right * 0.5f, _sightOrigin.position + base.transform.forward - base.transform.right * 0.5f);
		Gizmos.DrawLine(_sightOrigin.position + base.transform.forward + base.transform.right * 0.5f, _sightOrigin.position + base.transform.forward - base.transform.right * 0.5f);
	}
}
