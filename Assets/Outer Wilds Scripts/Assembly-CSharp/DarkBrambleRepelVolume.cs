using UnityEngine;

[RequireComponent(typeof(SphereShape))]
[RequireComponent(typeof(OWTriggerVolume))]
public class DarkBrambleRepelVolume : MonoBehaviour
{
	[SerializeField]
	private float _innerRadius;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(base.transform.position, _innerRadius);
	}
}
