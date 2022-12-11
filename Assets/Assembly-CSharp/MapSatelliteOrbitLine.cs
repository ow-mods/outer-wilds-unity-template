using UnityEngine;

public class MapSatelliteOrbitLine : OrbitLine
{
	[Space]
	[SerializeField]
	private ReferenceFrameVolume _rfVolume;
	[SerializeField]
	private float _lockOnFadeLength = 1f;
	[SerializeField]
	private float _minAlpha;
}
