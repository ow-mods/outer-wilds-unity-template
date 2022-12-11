using UnityEngine;

public class ElevatorGearInterface : AbstractGhostElevatorInterface
{
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private GearInterfaceEffects _gearEffects;
}