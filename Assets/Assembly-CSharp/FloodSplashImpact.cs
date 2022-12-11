using UnityEngine;

public class FloodSplashImpact : MonoBehaviour
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private OWRenderer _renderer;
	[Space]
	[SerializeField]
	private float _lifetime = 1f;
	[SerializeField]
	private float _delay;
	[SerializeField]
	private AnimationCurve _yOffsetOverLife = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	[SerializeField]
	private AnimationCurve _cutoffOverLife = AnimationCurve.Linear(0f, 0.5f, 1f, 1f);
}
