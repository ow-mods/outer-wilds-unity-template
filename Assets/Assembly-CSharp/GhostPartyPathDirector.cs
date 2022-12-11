using System;
using UnityEngine;

public class GhostPartyPathDirector : GhostDirector
{
	[Serializable]
	private struct GhostSpawnLocation
	{
		public Transform spawnTransform;
		public AbstractDoor spawnDoor;
		[NonSerialized]
		public float spawnDoorTimer;
	}

	[Serializable]
	private struct GhostFinalDestination
	{
		public Transform destinationTransform;
		public ProxyGhostController proxyGhost;
	}

	[Space]
	[SerializeField]
	private GhostSpawnLocation[] _ghostSpawns = new GhostSpawnLocation[0];
	[SerializeField]
	private float _minGhostDispatchDelay = 10f;
	[SerializeField]
	private float _maxGhostDispatchDelay = 90f;
	[SerializeField]
	private GhostFinalDestination[] _ghostFinalDestinations = new GhostFinalDestination[0];
	[SerializeField]
	private Transform[] _ghostOverflowFinalDestinations = new Transform[0];
	[SerializeField]
	private OWTriggerVolume _respawnBlockTrigger;
}
