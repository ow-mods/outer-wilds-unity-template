using UnityEngine;

public class TriggerTest : MonoBehaviour
{
	[SerializeField]
	private bool _triggerOn;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = (_triggerOn ? Color.red : Color.green);
		Gizmos.DrawWireSphere(base.transform.position, 100f);
	}
}
