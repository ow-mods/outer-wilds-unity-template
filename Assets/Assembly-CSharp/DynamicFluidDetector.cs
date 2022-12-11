using UnityEngine;

public class DynamicFluidDetector : FluidDetector
{
	[SerializeField]
	protected float _dragFactor = 1f;
	[SerializeField]
	protected float _angularDragFactor = 1f;
}
