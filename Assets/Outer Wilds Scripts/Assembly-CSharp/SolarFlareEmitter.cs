using UnityEngine;

public class SolarFlareEmitter : MonoBehaviour
{
	[SerializeField]
	private GameObject _streamerPrefab;
	[SerializeField]
	private GameObject _loopPrefab;
	[SerializeField]
	private GameObject _domePrefab;
	[Space]
	[SerializeField]
	private float _lifeLength = 15f;
	[SerializeField]
	private Color _tint = Color.white;
	[Space]
	[SerializeField]
	private float _minTimeBetweenFlares = 5f;
	[SerializeField]
	private float _maxTimeBetweenFlares = 30f;
	[SerializeField]
	private AnimationCurve _flareFrequencyTimeloopScale = AnimationCurve.EaseInOut(0f, 1f, 20f, 5f);
	[Space]
	[SerializeField]
	private int _minStreamersPerFlare = 1;
	[SerializeField]
	private int _maxStreamersPerFlare = 3;
	[Space]
	[SerializeField]
	private float _startScale = 0.01f;
	[SerializeField]
	private float _endScale = 0.1f;
}
