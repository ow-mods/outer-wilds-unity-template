using UnityEngine;

public class TimelineObliterationEffect : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve _lengthProgressionCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	[SerializeField]
	private float _randomDelay = 1f;
}
