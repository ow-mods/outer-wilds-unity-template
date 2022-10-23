using UnityEngine;

public class TornadoFluidVolume : FluidVolume
{
	[SerializeField]
	private Transform _tornadoPivot;
	[SerializeField]
	private float _verticalSpeed = 300f;
	[SerializeField]
	private float _angularSpeed = 10f;
	[SerializeField]
	private float _inwardSpeed = 100f;
	
	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
	}
}
