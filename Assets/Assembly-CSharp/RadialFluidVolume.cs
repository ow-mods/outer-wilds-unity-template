using UnityEngine;

public class RadialFluidVolume : FluidVolume
{
	[SerializeField]
	protected float _buoyancyDensity = 1f;
	[SerializeField]
	protected float _radius;

	protected virtual void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireSphere(base.transform.position, _radius);
	}
}
