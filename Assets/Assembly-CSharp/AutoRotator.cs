using UnityEngine;

public class AutoRotator : MonoBehaviour
{
	private enum RotationAxis
	{
		X = 0,
		Y = 1,
		Z = 2,
	}

	[SerializeField]
	private RotationAxis _visualRotationAxis;
	[SerializeField]
	private RotationAxis _actualRotationAxis;
	[SerializeField]
	private float _totalRotationTime = -1f;
	[SerializeField]
	private float _maxRotationSpeed;
	[SerializeField]
	private DampedSpringRadial _rotationSpringRampUp = new DampedSpringRadial();
	[SerializeField]
	private DampedSpringRadial _rotationSpringRampDown = new DampedSpringRadial();
	[SerializeField]
	private bool _startOnLoad;
	[SerializeField]
	private bool _rampUpRotation = true;
	[SerializeField]
	private bool _rampDownRotation = true;
}
