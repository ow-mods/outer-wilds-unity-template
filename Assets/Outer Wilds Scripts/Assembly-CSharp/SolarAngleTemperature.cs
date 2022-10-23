using UnityEngine;

public class SolarAngleTemperature : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve _temperatureCurve;
	[SerializeField]
	private float _maxTempK = 720f;
	[SerializeField]
	private float _minTempK = 100f;
}
