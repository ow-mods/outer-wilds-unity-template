using UnityEngine;

public class NomaiRotator : MonoBehaviour
{
	[SerializeField]
	protected float _cycleLength = 1f;
	[Space(10f)]
	[SerializeField]
	protected NomaiInterfaceSlot[] _openSwitches = new NomaiInterfaceSlot[0];
	[SerializeField]
	protected NomaiInterfaceSlot[] _closeSwitches = new NomaiInterfaceSlot[0];
	[SerializeField]
	protected NomaiInterfaceSlot[] _cycleSwitches = new NomaiInterfaceSlot[0];
	[Space(10f)]
	[SerializeField]
	protected OWAudioSource _audioSource;
}
