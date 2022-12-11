using UnityEngine;

public class EclipseCodeController3 : SectoredMonoBehaviour
{
	[SerializeField]
	private MultiInteractReceiver _interactReceiver;
	[SerializeField]
	private GearInterfaceEffects _gearInterface;
	[SerializeField]
	private RotaryDial[] _dials;
	[Space]
	[SerializeField]
	private SingleLightSensor _lightSensor;
	[SerializeField]
	private Transform _lightSensorRoot;
	[Space]
	[SerializeField]
	private int[] _code;
	[Space]
	[SerializeField]
	private AbstractDoor _frontDoor;
}
