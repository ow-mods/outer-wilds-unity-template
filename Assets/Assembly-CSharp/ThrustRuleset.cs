using UnityEngine;

public class ThrustRuleset : RulesetVolume
{
	[SerializeField]
	private float _thrustLimit = float.PositiveInfinity;
	[SerializeField]
	private bool _nerfJetpackBooster;
	[SerializeField]
	private float _nerfDuration = 0.5f;
}
