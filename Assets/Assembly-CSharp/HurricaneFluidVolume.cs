using UnityEngine;

[RequireComponent(typeof(ConeShape))]
public class HurricaneFluidVolume : FluidVolume
{
	[SerializeField]
	private float _flowSpeed = 200f;
	[SerializeField]
	private float _wallApproachThickness = 100f;
	[SerializeField]
	private float _wallThickness = 100f;
}
