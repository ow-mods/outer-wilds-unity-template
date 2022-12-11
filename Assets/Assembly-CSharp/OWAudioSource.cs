using UnityEngine;

[AddComponentMenu("Audio/OW Audio Source", 250)]
[RequireComponent(typeof(AudioSource))]
public class OWAudioSource : MonoBehaviour
{
	public enum FadeOutCompleteAction
	{
		STOP,
		PAUSE,
		CONTINUE
	}

	public enum ClipSelectionOnPlay
	{
		RANDOM = 0,
		SEQUENTIAL = 1,
		MANUAL = 2,
	}

	[SerializeField]
	private AudioType _audioLibraryClip;
	[SerializeField]
	private ClipSelectionOnPlay _clipSelectionOnPlay;
	[SerializeField]
	private OWAudioMixer.TrackName _track;
	[SerializeField]
	private bool _randomizePlayheadOnAwake;
}
