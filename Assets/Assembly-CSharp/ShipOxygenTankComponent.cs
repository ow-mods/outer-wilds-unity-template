using UnityEngine;

public class ShipOxygenTankComponent : ShipComponent
{
	[Space(10f)]
	[SerializeField]
	private float _oxygenLeakRate = 5f;
}
