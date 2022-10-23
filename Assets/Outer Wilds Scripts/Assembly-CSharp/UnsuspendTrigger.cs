using UnityEngine;

[RequireComponent(typeof(OWRigidbody))]
public class UnsuspendTrigger : MonoBehaviour
{
	[SerializeField]
	private OWTriggerVolume _unsuspendTrigger;
	[SerializeField]
	private OWTriggerVolume _suspendTrigger;
}
