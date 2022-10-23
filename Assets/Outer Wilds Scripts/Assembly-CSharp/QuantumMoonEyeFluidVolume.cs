using UnityEngine;

public class QuantumMoonEyeFluidVolume : FluidVolume
{
	[SerializeField]
	private float _upperRadius;
	[SerializeField]
	private float _lowerRadius;
	[SerializeField]
	private float _upperDensity;
	[SerializeField]
	private float _poleAttractSpeed = 20f;
	[SerializeField]
	private float _inwardSpeed = 10f;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireSphere(base.transform.position, _lowerRadius);
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(base.transform.position, _upperRadius);
	}
}
