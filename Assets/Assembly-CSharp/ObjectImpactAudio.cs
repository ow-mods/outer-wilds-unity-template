using UnityEngine;

[RequireComponent(typeof(OWAudioSource))]
public class ObjectImpactAudio : MonoBehaviour
{
	[SerializeField]
	private AudioType _clipType = AudioType.DefaultPropImpact;
	[SerializeField]
	private ImpactSensor _impactSensor;
	[SerializeField]
	private float _minSpeed = 1f;
	[SerializeField]
	private float _maxSpeed = 10f;
	[SerializeField]
	private float _minPitch = 1f;
	[SerializeField]
	private float _maxPitch = 1f;
	[SerializeField]
	private float _minCollidingMass;
}
