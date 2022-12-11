using UnityEngine;

public class SupernovaEffectController : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem[] _explosionParticles;
	[SerializeField]
	private MeshRenderer _shockwave;
	[SerializeField]
	private float _shockwaveLength = 5f;
	[SerializeField]
	private AnimationCurve _shockwaveScale = AnimationCurve.Linear(0f, 0f, 1f, 100000f);
	[SerializeField]
	private AnimationCurve _shockwaveAlpha = AnimationCurve.Linear(0f, 1f, 1f, 0f);
	[Space]
	[SerializeField]
	private TessellatedSphereRenderer _surface;
	[SerializeField]
	private Material _supernovaMaterial;
	[SerializeField]
	private SupernovaDestructionVolume _supernovaVolume;
	[SerializeField]
	private AnimationCurve _supernovaScale = AnimationCurve.Linear(5f, 0f, 15f, 50000f);
	[SerializeField]
	private AnimationCurve _supernovaAlpha = AnimationCurve.Linear(5f, 1f, 15f, 0f);
	[Space]
	[SerializeField]
	private OWAudioSource _audioSource;
}
