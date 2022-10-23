using UnityEngine;

public class ShipHeadlightComponent : ShipComponent
{
	[Space(10f)]
	[SerializeField]
	protected ElectricalSystem _electricalSystem;
	[SerializeField]
	protected ShipLight[] _headlights;
	[SerializeField]
	protected float _disruptionImpactSpeed = 30f;
	[SerializeField]
	protected float _disruptionLength = 1f;
}
