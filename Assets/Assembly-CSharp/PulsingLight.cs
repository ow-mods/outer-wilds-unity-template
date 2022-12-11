using UnityEngine;

public class PulsingLight : SectoredMonoBehaviour
{
	[Space(10f)]
	[SerializeField]
	private Renderer _emissiveRenderer;
	[SerializeField]
	private int _materialIndex;
	[Space(10f)]
	[SerializeField]
	private float _pulseRate = 1f;
	[SerializeField]
	private float _intensityFluctuation;
	[SerializeField]
	private float _rangeFluctuation;
	[SerializeField]
	private float _timeOffset;
}
