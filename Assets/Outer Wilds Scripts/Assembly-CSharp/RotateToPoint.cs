using UnityEngine;

public abstract class RotateToPoint : MonoBehaviour
{
	[SerializeField]
	private float _timeToMaxSpeed = 1f;
	[SerializeField]
	private float _targetLockAngle;
	[SerializeField]
	protected bool _quaternionTargetMode;
	[SerializeField]
	protected bool _setLocalRotationInQuatTargetMode;
	[SerializeField]
	private AnimationCurve _rampUpCurve;
}
