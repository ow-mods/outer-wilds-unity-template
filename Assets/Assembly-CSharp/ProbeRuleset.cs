using UnityEngine;

public class ProbeRuleset : RulesetVolume
{
	[SerializeField]
	private bool _overrideProbeSpeed = true;
	[SerializeField]
	private float _probeSpeedOverride;
	[Space]
	[SerializeField]
	private bool _overrideLanternRange;
	[SerializeField]
	private float _lanternRange;
	[Space]
	[SerializeField]
	private bool _ignoreAnchor;
}
