using UnityEngine;

public class WhiteHoleStationRotation : MonoBehaviour
{
	[SerializeField]
	private NomaiInterfaceSlot _slotClockwise;
	[SerializeField]
	private NomaiInterfaceSlot _slotCounterClockwise;
	[SerializeField]
	private OWRigidbody _stationBody;
	[SerializeField]
	private float _stationSlowdownFriction = 1f;
	[SerializeField]
	private float _stationAngularAcceleration = 1f;
	[SerializeField]
	private float _maxAngularVelocity = 0.1f;
	[SerializeField]
	private float _alignmentAngularVelThreshold = 0.25f;
	[SerializeField]
	private OWLightController _onLights;
	[SerializeField]
	private OWLightController _offLights;
	[Space]
	[SerializeField]
	private OWAudioSource _audioSource;
}
