using UnityEngine;

public class ShipFuelTankComponent : ShipComponent
{
	[Space(10f)]
	[SerializeField]
	private float _fuelLeakRate = 50f;
}
