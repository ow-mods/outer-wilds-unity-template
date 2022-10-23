using UnityEngine;

public class OWTriggerVolume : MonoBehaviour
{
	[SerializeField]
	private GameObject[] _initialOccupants = new GameObject[0];
	[SerializeField]
	private EntrywayTrigger[] _sharedEntryways = new EntrywayTrigger[0];
	[SerializeField]
	private bool _ignoreDuplicateOccupantWarning;
}
