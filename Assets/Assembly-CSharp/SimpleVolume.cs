using UnityEngine;

public abstract class SimpleVolume : MonoBehaviour
{
	public enum Shape
	{
		Sphere = 0,
		Capsule = 1,
		Box = 2,
	}

	[SerializeField]
	protected Shape _shape;
	[SerializeField]
	protected float _radius = 1f;
	[SerializeField]
	protected float _height = 2f;
	[SerializeField]
	protected Vector3 _size = Vector3.one;
}
