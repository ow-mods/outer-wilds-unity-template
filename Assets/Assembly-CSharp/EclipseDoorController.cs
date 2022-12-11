using UnityEngine;

public class EclipseDoorController : AbstractGhostDoorInterface
{
	[SerializeField]
	private SingleLightSensor[] _lightSensors;
	[SerializeField]
	private Transform[] _rotatingElements;
	[SerializeField]
	private AbstractDoor[] _backDoors;
	[SerializeField]
	private AbstractDoor _frontDoor;
	[Space]
	[SerializeField]
	private float _rotationSpeed = 180f;
	[SerializeField]
	private float _startingRotation = 270f;
	[SerializeField]
	private float _angleAccuracy = 10f;
	[Space]
	[SerializeField]
	private bool _disableSensorsWhileOpen;
	[SerializeField]
	private bool _canRotateWhileOpen = true;
	[SerializeField]
	private float _timeToClosure = 0.3f;
	[Header("Audio")]
	[SerializeField]
	private OWAudioSource _rotationAudio;
}
