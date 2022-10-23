using UnityEngine;

public class ShipLogEntryLocation : MonoBehaviour
{
	[SerializeField]
	private string _entryID = string.Empty;
	[SerializeField]
	private OuterFogWarpVolume _outerFogWarpVolume;
	[SerializeField]
	private bool _isWithinCloakField;
}
