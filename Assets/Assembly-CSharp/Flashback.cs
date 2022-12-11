using UnityEngine;

[RequireComponent(typeof(OWCamera))]
[RequireComponent(typeof(FlashbackRecorder))]
public class Flashback : MonoBehaviour
{
	[SerializeField]
	private float _screenStartDist = 12f;
	[SerializeField]
	private float _screenEndDist = 1f;
	[SerializeField]
	private float _playbackDelay = 6f;
	[SerializeField]
	private float _maskStartDist = 10f;
	[SerializeField]
	private float _maskEndDist = -1f;
	[SerializeField]
	private float _maskAnimDuration = 7f;
	[SerializeField]
	private float _lightFadeDuration = 5f;
	[SerializeField]
	private float _dataStreamDelay;
	[SerializeField]
	private float _dataStreamRevealDuration = 12f;
	[Space]
	[SerializeField]
	private float _reverseScreenStartDist = 2f;
	[SerializeField]
	private float _reverseScreenEndDist = 10f;
	[SerializeField]
	private float _reverseStreamRevealDuration = 3f;
	[SerializeField]
	private float _reversePlaybackDelay = 3f;
	[SerializeField]
	private float _reversePlaybackDuration = 7f;
	[SerializeField]
	private float _reverseScreenShrinkDuration = 3f;
	[Space]
	[SerializeField]
	private FlashbackAudioController _audioController;
	[SerializeField]
	private Transform _screenTransform;
	[SerializeField]
	private Transform _maskTransform;
	[SerializeField]
	private GameObject _forwardStreams;
	[SerializeField]
	private GameObject _reverseStreams;
	[Space]
	[SerializeField]
	private CanvasGroupAnimator _whiteFadeAnimator;
	[SerializeField]
	private AnimationCurve _whiteFadeCurve;
}
