using UnityEngine;

public class PlayerCloakEntryRedirector : MonoBehaviour
{
	[SerializeField]
	private CloakFieldController _cloakField;
	[SerializeField]
	private Transform _velocityTarget;
	[SerializeField]
	private float _targetRepositionAngle;
	[SerializeField]
	private float _maxEntryAngle;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.matrix = Matrix4x4.TRS(base.transform.position, base.transform.rotation, Vector3.one);
			Vector3 vector = Quaternion.AngleAxis(_maxEntryAngle, Vector3.forward) * Vector3.up;
			Gizmos.color = Color.green;
			Gizmos.DrawLine(Vector3.zero, Vector3.up * 800f);
			Gizmos.DrawLine(Vector3.zero, vector * 800f);
			OWGizmos.DrawWireArc(Vector3.zero, Vector3.forward, Vector3.up, _maxEntryAngle, 800f);
			Vector3 vector2 = Quaternion.AngleAxis(_targetRepositionAngle, Vector3.forward) * Vector3.up;
			Gizmos.color = Color.yellow;
			Gizmos.DrawLine(Vector3.zero, vector2 * 900f);
		}
	}
}
