using UnityEngine;

public class TimelineObliterationController : MonoBehaviour
{
	public enum ObliterationType
	{
		TIME_LOOP_EXPERIMENT,
		TIME_LOOP_CORE,
		PARADOX_DEATH,
		TIME_LOOP_CORE_AT_EYE,
		EXODIA
	}

	[SerializeField]
	private TimelineObliterationEffect[] _voidCrackEffectList;
	[SerializeField]
	private float _timeToCrackEffect;
	[SerializeField]
	private float _timeToScreenEffect;
	[SerializeField]
	private float _timeToParadoxDeathScreenEffect;
	[SerializeField]
	private OWAudioSource _screenShatterAudioSource;
	[SerializeField]
	private OWAudioSource _voidCrackAudioSource;
}
