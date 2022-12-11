using UnityEngine;

public class RotatingDoor : AbstractDoor
{
	[SerializeField]
	private Transform[] _doorPannelRight;
	[SerializeField]
	private Transform[] _doorPannelLeft;
	[SerializeField]
	private float _openRotation = 90f;
	[Space]
	[SerializeField]
	private float _openingSpeed = 60f;
	[SerializeField]
	private float _closingSpeed = 60f;
	[Header("Audio")]
	[SerializeField]
	private OWAudioSource _loopingAudio;
	[SerializeField]
	private OWAudioSource _oneShotAudio;
	[SerializeField]
	private AudioType _openStartClip = AudioType.Door_OpenStart;
	[SerializeField]
	private AudioType _openStopClip = AudioType.Door_OpenStop;
	[SerializeField]
	private AudioType _closeStartClip = AudioType.Door_CloseStart;
	[SerializeField]
	private AudioType _closeStopClip = AudioType.Door_CloseStop;
	[Header("Occlusion")]
	[SerializeField]
	private VolumeOcclusionLight _occlusionLight;
}
