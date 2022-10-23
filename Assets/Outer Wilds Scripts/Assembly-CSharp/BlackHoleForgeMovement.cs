using UnityEngine;

public class BlackHoleForgeMovement : MonoBehaviour
{
	[SerializeField]
	private float _movingLength = 5f;
	[SerializeField]
	private GameObject _lowerPosition;
	[SerializeField]
	private GameObject _midPosition;
	[SerializeField]
	private GameObject _highPosition;
	[SerializeField]
	private float _lowerPositionOffset;
	[SerializeField]
	private float _midPositionOffset;
	[SerializeField]
	private float _highPositionOffset;
	[SerializeField]
	private AnimationCurve _movingCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);
	[SerializeField]
	private AnimationCurve _rotationCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);
	[SerializeField]
	private NomaiInterfaceSlot[] _lowerSwitches = new NomaiInterfaceSlot[0];
	[SerializeField]
	private NomaiInterfaceSlot[] _middleSwitches = new NomaiInterfaceSlot[0];
	[SerializeField]
	private NomaiInterfaceSlot[] _higherSwitches = new NomaiInterfaceSlot[0];
	[SerializeField]
	private float _lowerRotation;
	[SerializeField]
	private float _midRotation;
	[SerializeField]
	private float _highRotation;
}
