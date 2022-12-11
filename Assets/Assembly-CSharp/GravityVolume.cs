using UnityEngine;

public class GravityVolume : ForceVolume
{
	private enum FalloffType
	{
		linear = 0,
		inverseSquared = 1,
		constant = 2,
	}

	[SerializeField]
	private bool _isPlanetGravityVolume = true;
	[SerializeField]
	protected float _surfaceAcceleration = 10f;
	[SerializeField]
	private float _cutoffAcceleration;
	[SerializeField]
	private FalloffType _falloffType;
	[SerializeField]
	private float _alignmentRadius = 0.1f;
	[SerializeField]
	private float _upperSurfaceRadius = 0.1f;
	[SerializeField]
	private float _lowerSurfaceRadius = 0.1f;
	[SerializeField]
	private float _cutoffRadius = 0.1f;
	[SerializeField]
	private bool _setMass = true;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = new ColorHSV(224f, 0.82f, 0.5f).ToColorRGB();
			OWGizmos.DrawWireCircle(base.transform.position, Vector3.up, _cutoffRadius);
			OWGizmos.DrawBillboardedWireCircle(base.transform.position, _cutoffRadius);
			Gizmos.color = new ColorHSV(224f, 0.68f, 0.95f).ToColorRGB();
			OWGizmos.DrawWireCircle(base.transform.position, Vector3.up, _lowerSurfaceRadius);
			OWGizmos.DrawBillboardedWireCircle(base.transform.position, _lowerSurfaceRadius);
			Gizmos.color = new ColorHSV(224f, 0.54f, 1f).ToColorRGB();
			OWGizmos.DrawWireCircle(base.transform.position, Vector3.up, _upperSurfaceRadius);
			OWGizmos.DrawBillboardedWireCircle(base.transform.position, _upperSurfaceRadius);
			Gizmos.color = Color.yellow;
			OWGizmos.DrawWireCircle(base.transform.position, Vector3.up, _alignmentRadius);
			OWGizmos.DrawBillboardedWireCircle(base.transform.position, _alignmentRadius);
		}
	}
}
