using UnityEngine;

public class NomaiGatewaySlab : MonoBehaviour
{
	[SerializeField]
	private float _openOffset;
	[SerializeField]
	private bool _rotate;
	[SerializeField]
	private float _speed = 1f;
	[SerializeField]
	private float _acceleration = 0.1f;

	private void OnDrawGizmos()
	{
		if (!_rotate)
		{
			Gizmos.color = Color.red;
			Gizmos.DrawLine(base.transform.position, base.transform.position - base.transform.right * _openOffset);
		}
	}
}
