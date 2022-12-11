using UnityEngine;

public class SlidingDoor : AbstractDoor
{
	[SerializeField]
	private Transform _doorTransform;
	[SerializeField]
	private Transform _closedSocket;
	[SerializeField]
	private Transform _openSocket;
	[Space]
	[SerializeField]
	private float _speed = 2f;
	[Space]
	[SerializeField]
	private OWAudioSource _loopingAudio;
	[SerializeField]
	private OWAudioSource _oneShotAudio;
}
