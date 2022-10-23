using UnityEngine;

public class CapsuleProximityTrigger : ProximityTrigger
{
	[SerializeField]
	private float _radius;
	[SerializeField]
	private float _length;

	public float radius
	{
		get
		{
			return _radius;
		}
		set
		{
			_radius = value;
		}
	}

	public float length
	{
		get
		{
			return _length;
		}
		set
		{
			_length = value;
		}
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = new Color(0f, 1f, 0f, 0.5f);
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			OWGizmos.DrawWireCapsule(base.transform.position, base.transform.rotation, _length, _radius);
		}
		else
		{
			OWGizmos.DrawWireCapsuleOutline(base.transform.position, base.transform.rotation, _length, _radius);
		}
	}
}
