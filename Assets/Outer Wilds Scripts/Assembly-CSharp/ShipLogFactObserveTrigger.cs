using UnityEngine;

public class ShipLogFactObserveTrigger : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private string _factID = string.Empty;
	[SerializeField]
	private string[] _factIDs;
	[SerializeField]
	private float _maxViewDistance = 2f;
	[SerializeField]
	private float _maxViewAngle = 180f;
	[SerializeField]
	private bool _disableColliderOnRevealFact;

	private void OnDrawGizmosSelected()
	{
		Quaternion quaternion = Quaternion.AngleAxis(_maxViewAngle, base.transform.up);
		Vector3 vector = quaternion * (base.transform.forward * _maxViewDistance);
		Vector3 vector2 = Quaternion.Inverse(quaternion) * (base.transform.forward * _maxViewDistance);
		Gizmos.color = Color.cyan;
		Gizmos.DrawLine(base.transform.position, base.transform.position + vector);
		Gizmos.DrawLine(base.transform.position, base.transform.position + vector2);
		Gizmos.color = Color.blue;
		OWGizmos.DrawWireCircle(base.transform.position, base.transform.up, _maxViewDistance);
	}
}
