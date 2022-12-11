using UnityEngine;

public class WineCellarSwitch : MonoBehaviour
{
	[SerializeField]
	private float _bottleAnimDuration = 0.5f;
	[SerializeField]
	private TransformAnimator _bottleAnimator;
	[SerializeField]
	private SlidingDoor _slidingDoor;
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private OWAudioSource _audioSource;
}