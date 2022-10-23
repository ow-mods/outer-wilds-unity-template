using System;
using UnityEngine;

public class GhostZone2Director : GhostDirector
{
	[Serializable]
	public struct ElevatorPair
	{
		public CageElevator elevator;
		public GhostNodeMap nodeMap;
		public GhostBrain ghost;
		public bool cityDestination;
	}

	[Space]
	[SerializeField]
	private DreamObjectProjector _lightsProjector;
	[SerializeField]
	private DreamObjectProjector _raftProjector;
	[SerializeField]
	private OWAudioSource _ghostHowlAudioSource;
	[SerializeField]
	private OWTriggerVolume _undergroundVolume;
	[SerializeField]
	private OWTriggerVolume _raftDockVolume;
	[SerializeField]
	private OWTriggerVolume _upperTowerEscapeVolume;
	[Space]
	[SerializeField]
	private GhostBrain[] _cityGhosts = new GhostBrain[0];
	[SerializeField]
	private GhostBrain[] _undergroundGhosts = new GhostBrain[0];
	[SerializeField]
	private ElevatorPair[] _elevators = new ElevatorPair[0];
	[SerializeField]
	private GhostNodeMap _cityNodeMap;
	[SerializeField]
	private GhostNodeMap _undercityNodeMap;
	[SerializeField]
	private CageElevator _ghostTutorialElevator;
	[SerializeField]
	private OWTriggerVolume _ghostTutorialArrival;
	[SerializeField]
	private AlarmTotem _finalTotem;
	[SerializeField]
	private Transform _teleportNode;
}
