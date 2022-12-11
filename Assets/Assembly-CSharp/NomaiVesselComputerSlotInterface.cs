using UnityEngine;

[RequireComponent(typeof(NomaiVesselComputer))]
public class NomaiVesselComputerSlotInterface : MonoBehaviour
{
	[SerializeField]
	private NomaiInterfaceSlot _slot;
	[SerializeField]
	private TextAsset _overrideText;
}
