using UnityEngine;

[RequireComponent(typeof(OWOceanCollider))]
[RequireComponent(typeof(WaveHeightCalculator))]
public class SphereOceanFluidVolume : RadialFluidVolume
{
	[SerializeField]
	private float _surfaceCurrentSpeed = 10f;
	[SerializeField]
	private float _equatorRepelAngle = 20f;
	[SerializeField]
	private float _equatorRepelSpeed = 1f;
	[SerializeField]
	private float _barrierUpperRadius = 460f;
	[SerializeField]
	private float _barrierLowerRadius = 440f;
	[SerializeField]
	private float _barrierRepelSpeed = 50f;

	protected override void OnDrawGizmosSelected()
	{
		base.OnDrawGizmosSelected();
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(base.transform.position, _barrierLowerRadius);
		Gizmos.DrawWireSphere(base.transform.position, _barrierUpperRadius);
	}
}
