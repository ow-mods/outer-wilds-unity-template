using UnityEngine;

[RequireComponent(typeof(CapsuleCollider))]
public class TractorBeamFluid : FluidVolume
{
	[SerializeField]
	private float _radius = 2f;
	[SerializeField]
	private float _height = 20f;
	[SerializeField]
	private float _verticalSpeed = 10f;
	[SerializeField]
	private float _reverseSpeed = -10f;
	[SerializeField]
	private float _inwardSpeed = 5f;
	[SerializeField]
	private float _outwardSpeed = 3f;
	[SerializeField]
	private float _exitLength;
	[SerializeField]
	private float _exitOffset;
	[SerializeField]
	private bool _fadeBeamIfPlayerInside;
	[SerializeField]
	private TractorBeamParticleController _ringParticleController;

	private void OnValidate()
	{
		if (base.transform.localPosition.x != 0f || base.transform.localPosition.z != 0f)
		{
			base.transform.localPosition = new Vector3(0f, base.transform.localPosition.y, 0f);
		}
		if (base.transform.localRotation != Quaternion.identity)
		{
			base.transform.localRotation = Quaternion.identity;
		}
		if (base.transform.localScale != Vector3.one)
		{
			base.transform.localScale = Vector3.one;
		}
		float num = Mathf.Max(0f, _radius);
		float num2 = Mathf.Max(num, _height);
		float num3 = Mathf.Max(num, num2 * 0.5f);
		CapsuleCollider component = GetComponent<CapsuleCollider>();
		if (_radius != num || _height != num2 || component.radius != num || component.height != num2 || component.center.y != num3)
		{
			_radius = num;
			_height = num2;
			component.radius = num;
			component.height = num2;
			component.center = new Vector3(component.center.x, num3, component.center.z);
		}
	}

	private void OnDrawGizmosSelected()
	{
		Vector3 vector = base.transform.position + base.transform.up * _exitOffset;
		Vector3 vector2 = vector + _exitLength * base.transform.up;
		Gizmos.color = new ColorHSV(148f, 1f, 1f).ToColorRGB();
		OWGizmos.DrawWireCircle(vector, base.transform.up, _radius);
		OWGizmos.DrawWireCircle(vector2, base.transform.up, _radius);
		Gizmos.color = new ColorHSV(148f, 1f, 1f).ToColorRGB();
		Gizmos.DrawLine(vector, vector2);
	}
}
