using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class FluidTrailEmitter : MonoBehaviour
{
	[SerializeField]
	private FluidDetector _fluidDetector;
	[SerializeField]
	private FluidVolume.Type _fluidType = FluidVolume.Type.AIR;
	[SerializeField]
	private float _speedScale = 1f;
	[SerializeField]
	private float _emissionRate = 10f;
	[SerializeField]
	private AnimationCurve _emissionRateDensityScale = AnimationCurve.Linear(0f, 0f, 1.2f, 1f);
	[SerializeField]
	private AnimationCurve _emissionRateFluidSpeedScale = AnimationCurve.Linear(0f, 0f, 10f, 1f);
	[SerializeField]
	private bool _startLifetimeByDensity;
	[SerializeField]
	private AnimationCurve _startLifetimeByDensityCurve = AnimationCurve.Linear(0f, 0f, 1.2f, 1f);
	[SerializeField]
	private bool _startLifetimeByFluidSpeed;
	[SerializeField]
	private AnimationCurve _startLifetimeByFluidSpeedCurve = AnimationCurve.Linear(0f, 0f, 1.2f, 1f);
	[SerializeField]
	private bool _startColorByDensity;
	[SerializeField]
	private float _startColorByDensityMin;
	[SerializeField]
	private float _startColorByDensityMax = 1.2f;
	[SerializeField]
	private Gradient _startColorByDensityGradient = new Gradient();
	[SerializeField]
	private bool _startColorByFluidSpeed;
	[SerializeField]
	private float _startColorByFluidSpeedMin;
	[SerializeField]
	private float _startColorByFluidSpeedMax = 10f;
	[SerializeField]
	private Gradient _startColorByFluidSpeedGradient = new Gradient();
}
