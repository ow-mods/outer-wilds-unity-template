using UnityEngine;

[AddComponentMenu("Shapes/Cone Shape", 5)]
public class ConeShape : Shape
{
	[SerializeField]
	protected Vector3 _center = Vector3.zero;
	[SerializeField]
	protected float _topRadius;
	[SerializeField]
	protected float _bottomRadius = 0.5f;
	[SerializeField]
	protected float _height = 1f;
	[SerializeField]
	protected int _direction = 1;

	protected virtual void OnValidate()
	{
		if (_topRadius < 0f)
		{
			_topRadius = 0f;
		}
		if (_bottomRadius < 0f)
		{
			_bottomRadius = 0f;
		}
		if (_height < 0f)
		{
			_height = 0f;
		}
		if (_direction < 0)
		{
			_direction = 0;
		}
		if (_direction > 2)
		{
			_direction = 2;
		}
	}
}
