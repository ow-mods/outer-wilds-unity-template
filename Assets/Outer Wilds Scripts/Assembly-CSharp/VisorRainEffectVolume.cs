using UnityEngine;

public class VisorRainEffectVolume : VisorEffectVolume
{
	public enum RainDirection
	{
		Linear = 0,
		Radial = 1,
	}

	[SerializeField]
	private RainDirection _rainDirection;
	[SerializeField]
	private float _dropletRate = 10f;
	[SerializeField]
	private AnimationCurve _dropletDirScale = AnimationCurve.EaseInOut(-1f, 0f, 1f, 1f);
	[SerializeField]
	private float _streakRate = 1f;
	[SerializeField]
	private AnimationCurve _streakDirScale = AnimationCurve.EaseInOut(-1f, 1f, 1f, 0f);
}
