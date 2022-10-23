using UnityEngine;

public class AlarmSequenceController : MonoBehaviour
{
	[SerializeField]
	private float _wakeDuration = 5f;
	[SerializeField]
	private float _recoveryDuration = 2f;
	[Header("Audio")]
	[SerializeField]
	private float _audioLingerTime = 3f;
	[SerializeField]
	private AnimationCurve _volumeCurve;
	[Header("Pulse")]
	[SerializeField]
	private float _pulseAttackLength = 0.2f;
	[SerializeField]
	private float _pulseHoldLength = 0.1f;
	[SerializeField]
	private float _pulseCooldownLength = 1f;
}
