using UnityEngine;

public class SolarDistanceTemperature : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve _distanceCurve;
	[SerializeField]
	private float _maxTempK = 1000f;
	[SerializeField]
	private float _minTempK = 80f;
	[SerializeField]
	private float _maxDistance = 25000f;
	[SerializeField]
	private float _minDistance;
}
