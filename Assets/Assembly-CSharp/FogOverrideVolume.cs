using UnityEngine;

public class FogOverrideVolume : SimpleVolume
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private float _blendDistance = 1f;
	[SerializeField]
	private bool _overrideDensity;
	[SerializeField]
	private float _density = 1f;
	[SerializeField]
	private bool _overrideColorRampIntensity;
	[SerializeField]
	private float _colorRampIntensity = 1f;
	[SerializeField]
	private bool _overrideTint;
	[SerializeField]
	private Color _tint = Color.white;
}
