using UnityEngine;

public class SingleLightSensor : LightSensor
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private bool _startIlluminated;
	[SerializeField]
	private bool _preserveStateWhileDisabled;
	[Space]
	[SerializeField]
	private bool _detectFlashlight;
	[SerializeField]
	private bool _detectProbe;
	[SerializeField]
	private bool _detectDreamLanterns;
	[SerializeField]
	private bool _detectSimpleLanterns;
	[SerializeField]
	private float _lanternFocusThreshold;
	[Space]
	[SerializeField]
	private bool _checkForOcclusion = true;
	[SerializeField]
	private float _maxDistance = float.PositiveInfinity;
	[SerializeField]
	private float _maxSimpleLanternDistance = float.PositiveInfinity;
	[SerializeField]
	private float _maxSpotHalfAngle = float.PositiveInfinity;
	[Space]
	[SerializeField]
	private bool _directionalSensor;
	[SerializeField]
	private Vector3 _localDirection = Vector3.forward;
	[SerializeField]
	private float _detectionAngle = 90f;
	[Space]
	[SerializeField]
	private float _sensorRadius;
	[SerializeField]
	private Vector3 _localSensorOffset;

	private void OnDrawGizmosSelected()
	{
		Vector3 vector = base.transform.TransformPoint(_localSensorOffset);
		Vector3 direction = base.transform.TransformDirection(_localDirection);
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(vector, Mathf.Max(0.1f, _sensorRadius));
		if (_directionalSensor)
		{
			Gizmos.DrawRay(vector, direction);
		}
	}
}
