using UnityEngine;

[AddComponentMenu("Shapes/Capsule Shape", 2)]
public class CapsuleShape : Shape
{
	[SerializeField]
	protected Vector3 _center = Vector3.zero;
	[SerializeField]
	protected float _radius = 0.5f;
	[SerializeField]
	protected float _height = 1f;
	[SerializeField]
	protected int _direction = 1;

	public Vector3 center
	{
		get
		{
			return _center;
		}
		set
		{
			_center = value;
		}
	}

	public float radius
	{
		get
		{
			return _radius;
		}
		set
		{
			_radius = Mathf.Max(value, 0f);
		}
	}

	public float height
	{
		get
		{
			return _height;
		}
		set
		{
			_height = Mathf.Max(value, 0f);
		}
	}

	public int direction
	{
		get
		{
			return _direction;
		}
		set
		{
			_direction = Mathf.Clamp(value, 0, 2);
		}
	}

	[ContextMenu("Copy from Capsule Collider", true)]
	private bool ValidateCopySettingsFromCollider()
	{
		return GetComponent<CapsuleCollider>() != null;
	}

	[ContextMenu("Copy from Capsule Collider", false)]
	private void CopySettingsFromCollider()
	{
		CapsuleCollider component = GetComponent<CapsuleCollider>();
		_center = component.center;
		_radius = component.radius;
		_height = component.height;
		_direction = component.direction;
	}

	[ContextMenu("Copy from Capsule Proximity Trigger", true)]
	private bool ValidateCopySettingsFromCapsuleProximityTrigger()
	{
		return GetComponent<CapsuleProximityTrigger>() != null;
	}

	[ContextMenu("Copy from Capsule Proximity Trigger", false)]
	private void CopySettingsFromCapsuleProximityTrigger()
	{
		CapsuleProximityTrigger component = GetComponent<CapsuleProximityTrigger>();
		_center = Vector3.zero;
		_radius = component.radius;
		_height = component.length + component.radius * 2f;
		_direction = 1;
	}

	protected virtual void OnValidate()
	{
		if (_radius < 0f)
		{
			_radius = 0f;
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
