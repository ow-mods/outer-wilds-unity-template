using UnityEngine;

public class VisorFrostEffectVolume : VisorEffectVolume
{
	[SerializeField]
	private float _frostRate = 0.1f;
	[SerializeField]
	[Range(0f, 1f)]
	private float _maxFrost = 0.5f;
}
