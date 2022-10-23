using UnityEngine;

public class FluidDetector : PriorityDetector
{
	[SerializeField]
	protected BuoyancyData _buoyancy = new BuoyancyData();
	[SerializeField]
	private SplashEffect[] _splashEffects = new SplashEffect[0];
	[SerializeField]
	protected bool _dontApplyForces;
	[SerializeField]
	private Transform _splashSpawnRoot;

	private void OnDrawGizmosSelected()
	{
		if (_buoyancy.boundingRadius > 0f)
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawWireSphere(base.transform.position, _buoyancy.boundingRadius);
		}
	}
}
