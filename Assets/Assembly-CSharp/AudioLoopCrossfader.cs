using UnityEngine;

public class AudioLoopCrossfader : MonoBehaviour
{
	[SerializeField]
	private OWAudioSource _oneShotAudioStart;
	[SerializeField]
	private OWAudioSource _oneShotAudioEnd;
	[SerializeField]
	private OWAudioSource _loopingAudio;
	[Header("Start and end audio")]
	[SerializeField]
	private AudioType _startClip;
	[SerializeField]
	private AudioType _endClip;
	[Header("Audio fade controls")]
	[SerializeField]
	private float _loopFadeInDuration;
	[SerializeField]
	private float _loopFadeOutDuration;
	[SerializeField]
	private float _cancelFadeDuration = 0.2f;
}
