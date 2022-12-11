using UnityEngine;

public class EntrywayTrigger : MonoBehaviour
{
	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawRay(base.transform.position, base.transform.forward * 2f);
	}
}
