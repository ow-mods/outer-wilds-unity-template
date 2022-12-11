using UnityEngine;

public class RotatingDoubleDoor : AbstractDoor
{
	[SerializeField]
	private float _openDegrees;
	[SerializeField]
	private float _closedDegrees = 20f;
	[Space]
	[SerializeField]
	private float _speed = 5f;
	[Space]
	[SerializeField]
	private Transform _leftDoor;
	[SerializeField]
	private Transform _rightDoor;
	[Space]
	[SerializeField]
	private OWAudioSource _loopingAudio;
	[SerializeField]
	private OWAudioSource _oneShotAudio;
}
