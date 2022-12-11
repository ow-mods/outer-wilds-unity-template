using UnityEngine;

public class ImpactAudioPool : MonoBehaviour
{
	[SerializeField]
	private AudioType _clipType = AudioType.DefaultPropImpact;
	[SerializeField]
	private float _minMass = 0.1f;
	[SerializeField]
	private float _minSpeed = 1f;
	[SerializeField]
	private float _maxSpeed = 10f;
	[SerializeField]
	private ImpactSensor _impactSensor;
	[SerializeField]
	private OWAudioSource[] _audioSources;
}
