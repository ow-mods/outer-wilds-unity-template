using UnityEngine;

[RequireComponent(typeof(InteractVolume))]
public class ShipEjectionSystem : MonoBehaviour
{
	[SerializeField]
	private ShipDetachableModule _cockpitModule;
	[SerializeField]
	private float _ejectImpulse = 5f;
	[SerializeField]
	private Transform _cover;
	[SerializeField]
	private float _coverMoveTime = 1f;
	[SerializeField]
	private float _secondPressDelay = 0.25f;
}
