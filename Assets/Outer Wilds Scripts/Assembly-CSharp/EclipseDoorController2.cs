using UnityEngine;

public class EclipseDoorController2 : MonoBehaviour
{
	[SerializeField]
	private SingleLightSensor _frontLightSensor;
	[SerializeField]
	private SingleLightSensor _backLightSensor;
	[SerializeField]
	private Transform[] _rotatingElements;
	[SerializeField]
	private AbstractDoor[] _backDoors;
	[SerializeField]
	private AbstractDoor _frontDoor;
	[Space]
	[SerializeField]
	private float _rotationSpeed = 180f;
	[SerializeField]
	private float _startingRotation = 270f;
	[SerializeField]
	private float _anglePrecision = 10f;
}
