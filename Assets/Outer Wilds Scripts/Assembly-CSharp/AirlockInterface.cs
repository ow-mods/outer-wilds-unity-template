using UnityEngine;

public class AirlockInterface : AbstractGhostAirlockInterface
{
	[SerializeField]
	private SingleLightSensor[] _lightSensors;
	[SerializeField]
	private Transform[] _rotatingElements;
	[Header("Front Gear")]
	[SerializeField]
	private InteractReceiver _frontInterface;
	[SerializeField]
	private GearInterfaceEffects _frontGearEffects;
	[Header("Back Gear")]
	[SerializeField]
	private InteractReceiver _backInterface;
	[SerializeField]
	private GearInterfaceEffects _backGearEffects;
	[Space]
	[SerializeField]
	private float _maxSpeed = 54f;
	[SerializeField]
	private float _acceleration = 120f;
	[SerializeField]
	private float _deceleration = 216f;
	[SerializeField]
	private float _angleAccuracy = 10f;
	[Space]
	private float _currentRotation;
}
