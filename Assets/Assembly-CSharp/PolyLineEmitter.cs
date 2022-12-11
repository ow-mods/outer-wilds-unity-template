using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class PolyLineEmitter : MonoBehaviour
{
	[SerializeField]
	private Vector3[] _vertices = new Vector3[2]
	{
		Vector3.left,
		Vector3.right
	};
	[SerializeField]
	private bool _looped;
	[SerializeField]
	private int _burstCountMin = 30;
	[SerializeField]
	private int _burstCountMax = 40;
	[SerializeField]
	private float _burstLength;

	private void OnDrawGizmosSelected()
	{
		if (_vertices.Length >= 2)
		{
			Gizmos.color = Color.red;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			for (int i = 0; i < _vertices.Length - 1; i++)
			{
				Gizmos.DrawLine(_vertices[i], _vertices[i + 1]);
			}
			if (_looped)
			{
				Gizmos.DrawLine(_vertices[_vertices.Length - 1], _vertices[0]);
			}
		}
	}
}
