using UnityEngine;

public class ThrusterWashController : MonoBehaviour
{
	[SerializeField]
	private float _raycastDistance = 10f;
	[SerializeField]
	private AnimationCurve _emissionDistanceScale = AnimationCurve.Linear(0f, 1f, 10f, 0f);
	[SerializeField]
	private AnimationCurve _emissionThrusterScale = AnimationCurve.Linear(0f, 0f, 6f, 1f);
	[SerializeField]
	private ParticleSystem _defaultParticleSystem;
	[SerializeField]
	private ParticleSystem[] _particleSystemBySurfaceType = new ParticleSystem[24];
}
