using UnityEngine;

[RequireComponent(typeof(OWRenderer))]
public class SingularityController : MonoBehaviour
{
	public enum State
	{
		Creating,
		Stable,
		Collapsing,
		Collapsed
	}

	public enum TransitionEffectType
	{
		EnterBlackHole,
		ExitWhiteHole,
		PlayerEnterBlackHole,
		PlayerExitWhiteHole
	}

	[SerializeField]
	private AnimationCurve _creationCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);
	[SerializeField]
	private AnimationCurve _destructionCurve = AnimationCurve.EaseInOut(0f, 1f, 1f, 0f);
	[SerializeField]
	private bool _startActive;
	[SerializeField]
	private bool _muteSingularityEffectAudio = true;
	[SerializeField]
	private OWAudioSource _owAmbientSource;
	[SerializeField]
	private OWAudioSource _owOneShotSource;
}
