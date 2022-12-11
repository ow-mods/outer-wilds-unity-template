using UnityEngine;

public class ThrusterFlameController : MonoBehaviour
{
	[SerializeField]
	private Thruster _thruster;
	[SerializeField]
	private Light _light;
	[SerializeField]
	private AnimationCurve _scaleByThrust = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	[SerializeField]
	private DampedSpring _scaleSpring = new DampedSpring();
	[SerializeField]
	private float _belowMaxThrustScalar = 1f;
}
