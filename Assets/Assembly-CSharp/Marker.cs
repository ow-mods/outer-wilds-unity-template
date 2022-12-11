using UnityEngine;

public class Marker : MonoBehaviour
{
	private void OnDrawGizmos()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.color = Color.yellow;
		Gizmos.DrawSphere(Vector3.zero, 1f);
	}
}
