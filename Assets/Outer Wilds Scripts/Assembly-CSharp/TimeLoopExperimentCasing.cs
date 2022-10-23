using UnityEngine;

public class TimeLoopExperimentCasing : MonoBehaviour
{
	[SerializeField]
	private float _movingLength = 5f;
	[SerializeField]
	private GameObject _lowerPosition;
	[SerializeField]
	private GameObject _highPosition;
	[SerializeField]
	private AnimationCurve _movingCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);
	[SerializeField]
	private NomaiInterfaceSlot[] _lowerSwitches = new NomaiInterfaceSlot[0];
	[SerializeField]
	private NomaiInterfaceSlot[] _higherSwitches = new NomaiInterfaceSlot[0];
}
