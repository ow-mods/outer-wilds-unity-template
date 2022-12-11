using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
	[SerializeField]
	private Collider _bodyCollider;
	[SerializeField]
	private Collider _antiSinkingCollider;
	[SerializeField]
	private float _runSpeed = 6f;
	[SerializeField]
	private float _walkSpeed = 3f;
	[SerializeField]
	private float _strafeSpeed = 4f;
	[SerializeField]
	private float _acceleration = 0.5f;
	[SerializeField]
	private float _airSpeed = 3f;
	[SerializeField]
	private float _airAcceleration = 0.2f;
	[SerializeField]
	private float _minJumpSpeed = 3f;
	[SerializeField]
	private float _maxJumpSpeed = 6f;
	[Space]
	[SerializeField]
	private bool _useChargeJump = true;
	[SerializeField]
	private bool _useChargeCurve;
	[SerializeField]
	private AnimationCurve _jumpChargeCurve;
	[Space]
	[SerializeField]
	private float _minStaggerDamage = 5f;
	[SerializeField]
	private float _minStaggerLength = 1f;
	[SerializeField]
	private float _maxStaggerLength = 3f;
	[Space]
	[SerializeField]
	private float _tumbleThreshold = float.PositiveInfinity;
	[SerializeField]
	private float _tumbleDuration = 1.5f;
	[Space]
	[SerializeField]
	private int _maxAngleToBeGrounded = 45;
	[SerializeField]
	private int _maxAngleBetweenSlopes = 115;
	[Space]
	[SerializeField]
	private bool _groundSnappingEnabled = true;
	[SerializeField]
	private float _jumpDurationAfterUngrounded = 0.25f;
}
