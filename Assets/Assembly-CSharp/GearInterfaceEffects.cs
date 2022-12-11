using UnityEngine;

public class GearInterfaceEffects : MonoBehaviour
{
	[Tooltip("Degrees per second")]
	[SerializeField]
	private float _speed = 360f;
	[SerializeField]
	private bool _useUnscaledTime;
	[SerializeField]
	private Transform _transformOverride;
	[Header("Audio")]
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[Header("Failure Animation")]
	[SerializeField]
	private AnimationCurve _failureAnimation;
	[SerializeField]
	private float _failureAnimMaxAngle;
	[SerializeField]
	private float _failureAnimDuration;
}
