using UnityEngine;

public class GhostPartyDirector : GhostDirector
{
	[Space]
	[SerializeField]
	private OWTriggerVolume _doorGhostTrigger;
	[SerializeField]
	private OWTriggerVolume _doorTrapTrigger;
	[SerializeField]
	private AbstractDoor _entryDoor;
	[Space]
	[SerializeField]
	private OWTriggerVolume _ambushTrigger;
	[SerializeField]
	private float _initialAmbushDelay = 10f;
	[SerializeField]
	private float _secondaryAmbushDelay = 5f;
	[SerializeField]
	private GhostBrain _fireplaceGhost;
	[SerializeField]
	private GhostBrain[] _ambushGhosts = new GhostBrain[0];
	[Space]
	[SerializeField]
	private Sector _audioSector;
	[SerializeField]
	private PartyMusicController _partyMusicController;
	[Space]
	[SerializeField]
	private GameObject _shipLogFactObject;
}
