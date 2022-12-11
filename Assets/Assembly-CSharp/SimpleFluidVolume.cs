using UnityEngine;

public class SimpleFluidVolume : FluidVolume
{
	private enum FlowType
	{
		Linear = 0,
		Attractive = 1,
		Repulsive = 2,
	}

	[SerializeField]
	private FlowType _flowType;
	[SerializeField]
	private float _flowSpeed;
	[SerializeField]
	private Vector3 _localLinearFlow = Vector3.zero;
	[Space]
	[SerializeField]
	private bool _rumble;
	[SerializeField]
	private float _rumbleScale;

	private void OnDrawGizmosSelected()
	{
		if (_flowType == FlowType.Linear)
		{
			Gizmos.color = Color.red;
			Gizmos.DrawLine(base.transform.position, base.transform.position + base.transform.TransformDirection(_localLinearFlow) * _flowSpeed);
		}
	}
}
