using UnityEngine;

[RequireComponent(typeof(CapsuleCollider))]
public class RingWaveFluidVolume : FluidVolume
{
	[Space]
	[SerializeField]
	private RingRiverFluidVolume _riverFluid;
	[SerializeField]
	private float _radius;
	[SerializeField]
	private float _buoyancyDensity = 1.1f;
}
