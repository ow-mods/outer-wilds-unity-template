using UnityEngine;

public class ShipReactorComponent : ShipComponent
{
	[Space(10f)]
	[SerializeField]
	private float _minCountdown = 25f;
	[SerializeField]
	private float _maxCountdown = 35f;
	[Space]
	[SerializeField]
	private Transform _timerArrow;
	[SerializeField]
	private float _startArrowRotation = 30f;
	[SerializeField]
	private float _endArrowRotation = -90f;
}
