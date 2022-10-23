using UnityEngine;

public class MeteorController : MonoBehaviour
{
	[SerializeField]
	private float _minDamage = 20f;
	[SerializeField]
	private float _maxDamage = 80f;
	[Space]
	[SerializeField]
	private ConstantForceDetector _constantForceDetector;
	[SerializeField]
	private ConstantFluidDetector _constantFluidDetector;
	[SerializeField]
	private DynamicFluidDetector _dynamicFluidDetector;
	[Space]
	[SerializeField]
	private Renderer _intactRenderer;
	[SerializeField]
	private Light _glowLight;
	[SerializeField]
	private FluidTrailEmitter _smokeTrail;
	[SerializeField]
	private float _nonCollisionDuration = 1.5f;
	[Space]
	[SerializeField]
	private float _ambientCoolTime = 10f;
	[SerializeField]
	private float _impactedCoolTime = 5f;
	[SerializeField]
	private float _waterCoolTime = 3f;
	[SerializeField]
	private float _atmoEntryHeatScale = 10f;
	[SerializeField]
	private float _lightFadeTime = 1f;
	[Space]
	[SerializeField]
	private float _impactSuspendDelay = 5f;
	[SerializeField]
	private ParticleSystem[] _impactParticles = new ParticleSystem[0];
	[SerializeField]
	private Light _impactLight;
	[SerializeField]
	private AnimationCurve _impactLightCurve;
	[Space]
	[SerializeField]
	private OWAudioSource _impactSource;
}
