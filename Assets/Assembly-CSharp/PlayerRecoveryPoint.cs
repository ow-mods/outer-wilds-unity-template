using UnityEngine;

[RequireComponent(typeof(InteractVolume))]
public class PlayerRecoveryPoint : MonoBehaviour
{
	[SerializeField]
	private bool _refuelsPlayer = true;
	[SerializeField]
	private bool _healsPlayer;
	[SerializeField]
	private bool _cleansVisor;
	[SerializeField]
	private bool _DLCFuelTank;
}
