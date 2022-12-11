using UnityEngine;

[RequireComponent(typeof(BoxShape))]
public class FlatFluidVolume_Old : FluidVolume
{
	[Space]
	[SerializeField]
	private float _buoyancyDensity = 1.1f;
}
