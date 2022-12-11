using UnityEngine;
using System;

public class PossibilitySphereController : MonoBehaviour
{
	[Serializable]
	private struct ProbabilityParticleSystem
	{
		public ParticleSystem particleSystem;
		public float probability;
	}

	[SerializeField]
	private float _minIntensity = 0.5f;
	[SerializeField]
	private float _fadeInDuration = 0.1f;
	[SerializeField]
	private float _litDuration = 0.1f;
	[SerializeField]
	private float _fadeOutDuration = 0.05f;
	[SerializeField]
	private float _unlitDuration;
	[Space]
	[SerializeField]
	private OWLight[] _lights;
	[SerializeField]
	private ProbabilityParticleSystem[] _particles;
	[SerializeField]
	private Transform[] _randomRotationRoots;
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private OWAudioSource _ambientSource;
	[Header("Prisoner")]
	[SerializeField]
	private GameObject _prisonerObject;
	[SerializeField]
	private LightSensor _prisonerLightSensor;
	[SerializeField]
	private OWEmissiveRenderer[] _prisonerEyeRenderers;
}
