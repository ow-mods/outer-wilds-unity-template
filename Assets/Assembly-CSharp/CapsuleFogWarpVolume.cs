using UnityEngine;

public class CapsuleFogWarpVolume : FogWarpVolume
{
	[SerializeField]
	protected CapsuleFogWarpVolume _linkedCapsuleWarpVolume;
	[SerializeField]
	protected Vector3 _localExitDirection = Vector3.forward;
	[SerializeField]
	protected float _radius;
	[SerializeField]
	protected float _height;
	[SerializeField]
	protected float _minExitSpeed;

	private Vector3 GetWorldFacing()
	{
		return base.transform.TransformDirection(_localExitDirection);
	}

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = new ColorHSV(300f, 0.8f, 0.8f).ToColorRGB();
			OWGizmos.DrawWireCircle(base.transform.position, GetWorldFacing(), _radius);
			Gizmos.DrawLine(base.transform.position, base.transform.position + GetWorldFacing() * _height);
		}
	}
}
