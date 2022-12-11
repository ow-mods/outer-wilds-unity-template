using UnityEngine;

public class EclipseElevatorController : AbstractGhostElevatorInterface
{
	[SerializeField]
	private SingleLightSensor[] _lightSensors;
	[SerializeField]
	private Transform[] _rotatingElements;
	[Space]
	[SerializeField]
	private float _rotationSpeed = 180f;
	[SerializeField]
	private float _anglePrecision = 10f;
	[Header("Audio")]
	[SerializeField]
	private AudioLoopCrossfader _lightSensorCrossfader;
	[SerializeField]
	private OWAudioSource _rotationAudio;
}
