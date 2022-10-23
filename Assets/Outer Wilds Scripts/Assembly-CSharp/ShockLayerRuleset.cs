using UnityEngine;

public class ShockLayerRuleset : RulesetVolume
{
	public enum ShockType
	{
		None = 0,
		Radial = 1,
		Atmospheric = 2,
	}

	[SerializeField]
	private ShockType _type;
	[SerializeField]
	private Transform _radialCenter;
	[SerializeField]
	private float _innerRadius = 100f;
	[SerializeField]
	private float _outerRadius = 300f;
	[SerializeField]
	[ColorUsage(true, true)]
	private Color _color = new Color(2f, 2f, 2f, 1f);
	[Header("Atmospheric Settings")]
	[SerializeField]
	private float _minShockSpeed = 100f;
	[SerializeField]
	private float _maxShockSpeed = 300f;
	[Header("Radius Settings")]
	[SerializeField]
	private float _trailLength = 20f;
	[SerializeField]
	private float _trailFlare = 10f;
}
