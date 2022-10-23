using UnityEngine;

public class SunOverrideVolume : SimpleVolume
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private int _priority;
	[SerializeField]
	private float _blendDistance = 1f;
	[SerializeField]
	private bool _overrideColor;
	[SerializeField]
	private Color _color = Color.white;
	[SerializeField]
	private bool _overrideIntensity;
	[SerializeField]
	private float _intensity = 1f;
	[SerializeField]
	private bool _overrideAmbientIntensity;
	[SerializeField]
	private float _ambientIntensity = 1f;
	[SerializeField]
	private bool _overrideShadowStrength;
	[SerializeField]
	private float _shadowStrength = 1f;
}
