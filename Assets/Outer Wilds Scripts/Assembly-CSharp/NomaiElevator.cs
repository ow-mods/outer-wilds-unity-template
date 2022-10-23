using UnityEngine;

public class NomaiElevator : MonoBehaviour
{
	[SerializeField]
	protected NomaiInterfaceSlot[] _upSwitches = new NomaiInterfaceSlot[0];
	[SerializeField]
	protected NomaiInterfaceSlot[] _downSwitches = new NomaiInterfaceSlot[0];
	[SerializeField]
	private float _maxSpeed;
	[SerializeField]
	private float _acceleration;
	[SerializeField]
	private float _elevationGain;
	[SerializeField]
	private Transform _elevatorRoot;
	[SerializeField]
	private OWAudioSource _audioSource;
}
