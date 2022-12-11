using UnityEngine;

[AddComponentMenu("Shapes/Box Shape", 3)]
public class BoxShape : Shape
{
	[SerializeField]
	protected Vector3 _center = Vector3.zero;
	[SerializeField]
	protected Vector3 _size = Vector3.one;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawWireCube(base.transform.position + _center, Vector3.Scale(_size, base.transform.lossyScale));
	}
}
