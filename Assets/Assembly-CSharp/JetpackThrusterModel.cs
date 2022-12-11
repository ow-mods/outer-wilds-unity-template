using UnityEngine;

public class JetpackThrusterModel : ThrusterModel
{
	[SerializeField]
	private float _boostGroundVelocity = 2f;
	[SerializeField]
	private float _boostThrust = 23f;
	[SerializeField]
	private float _boostSeconds = 1f;
	[SerializeField]
	private float _chargeSecondsGround = 1f;
	[SerializeField]
	private float _chargeSecondsAir = 8f;
}
