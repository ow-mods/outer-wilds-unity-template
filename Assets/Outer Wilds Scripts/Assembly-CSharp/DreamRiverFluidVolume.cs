using UnityEngine;

[RequireComponent(typeof(BoxShape))]
public class DreamRiverFluidVolume : FlatFluidVolume
{
	[Space]
	[SerializeField]
	private float _defaultSpeed;
	[SerializeField]
	private float _densityForRaft = 100f;
	[SerializeField]
	private AnimationCurve _attractCurve;
	[SerializeField]
	private RiverFlowRail _rail;
}
