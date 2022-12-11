using UnityEngine;

public class RingRiverRuleset : RulesetVolume
{
	[SerializeField]
	private float _lowerFlowSpeed = 5f;
	[SerializeField]
	private float _upperFlowSpeed = 10f;
	[SerializeField]
	private RingRiverFluidVolume _fluidVolume;
}
