using UnityEngine;

public class SparkEffectController : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem _sparkParticleSystem;
	[SerializeField]
	private Light _sparkLight;
	[SerializeField]
	private float _minSparkDelay = 1f;
	[SerializeField]
	private float _maxSparkDelay = 3f;
	[SerializeField]
	private int _minSparkCount = 2;
	[SerializeField]
	private int _maxSparkCount = 7;
	[SerializeField]
	private float _sparkLightFadeSpeed = 1f;
}
