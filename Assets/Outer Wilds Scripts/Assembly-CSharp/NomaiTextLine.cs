using UnityEngine;

public class NomaiTextLine : MonoBehaviour
{
	public enum VisualState
	{
		HIDDEN,
		UNREAD,
		TRANSLATED
	}

	[SerializeField]
	private int _entryID = -1;
	[SerializeField]
	private Vector3[] _points = new Vector3[0];
	[SerializeField]
	[HideInInspector]
	private bool _prebuilt;
	[SerializeField]
	[HideInInspector]
	private float[] _lengths;
	[SerializeField]
	[HideInInspector]
	private float _totalLength;
	[SerializeField]
	[HideInInspector]
	private Vector3 _center = Vector3.zero;
	[SerializeField]
	[HideInInspector]
	private float _radius;

	private void OnDrawGizmosSelected()
	{
		Vector3 zero = Vector3.zero;
		for (int i = 0; i < _points.Length; i++)
		{
			zero += _points[i];
		}
		zero /= (float)_points.Length;
		Gizmos.color = Color.red;
		Gizmos.matrix = base.transform.localToWorldMatrix;
		for (int j = 0; j < _points.Length - 1; j++)
		{
			Gizmos.DrawLine(_points[j], _points[j + 1]);
		}
		for (int k = 0; k < _points.Length; k++)
		{
			Gizmos.DrawSphere(_points[k], 0.01f);
		}
		Gizmos.color = Color.yellow;
		Gizmos.DrawSphere(zero, 0.05f);
		OWGizmos.DrawWireCircle(zero, Vector3.forward, _radius);
	}
}
