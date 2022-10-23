using UnityEngine;

public class RotateTransform : MonoBehaviour
{
	[SerializeField]
	private Vector3 _localAxis;
	[SerializeField]
	private float _degreesPerSecond;
	[SerializeField]
	private bool _randomizeRotationRate;
	[SerializeField]
	private float _minRandomRate = -90f;
	[SerializeField]
	private float _maxRandomRate = 90f;
	[Header("Active Sector (Optional)")]
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private DynamicOccupantMask _sectorOccupantMask;

	private Transform _transform;

	private Quaternion _localRotation;

	private void Awake()
	{
		_transform = base.transform;
		_localRotation = base.transform.localRotation;
		_localAxis.Normalize();
		if (_randomizeRotationRate)
		{
			_degreesPerSecond = Random.Range(_minRandomRate, _maxRandomRate);
		}
	}

	private void Update()
	{
		_localRotation *= Quaternion.AngleAxis(_degreesPerSecond * Time.deltaTime, _localAxis);
		_transform.localRotation = _localRotation;
	}
}
