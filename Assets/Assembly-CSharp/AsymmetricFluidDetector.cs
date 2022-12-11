using UnityEngine;

public class AsymmetricFluidDetector : FluidDetector
{
	[SerializeField]
	protected Vector3 _dragFactor = Vector3.one;
	[SerializeField]
	private Vector3 _angularDragVector = Vector3.one;
	[SerializeField]
	private float _angularDragFactor = 1f;
}
