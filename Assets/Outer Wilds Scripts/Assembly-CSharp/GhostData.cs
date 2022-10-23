using UnityEngine;

public class GhostData
{
	public enum ThreatAwareness
	{
		EverythingIsNormal = 0,
		SomethingIsAmiss = 10,
		SomeoneIsInHere = 20,
		IntruderConfirmed = 30,
	}

	public GhostLocationData playerLocation = new GhostLocationData();
	public GhostLocationData lastKnownPlayerLocation = new GhostLocationData();
	public GhostSensorData sensor = new GhostSensorData();
	public GhostSensorData lastKnownSensor = new GhostSensorData();
	private GhostSensorData firstUnknownSensor = new GhostSensorData();
	public ThreatAwareness threatAwareness;
	public GhostAction.Name currentAction = GhostAction.Name.None;
	public GhostAction.Name previousAction = GhostAction.Name.None;
	public bool isAlive = true;
	public bool hasWokenUp;
	public bool isPlayerLocationKnown;
	public bool wasPlayerLocationKnown;
	public bool reduceGuardUtility;
	public bool fastStalkUnlocked;
	public float timeLastSawPlayer;
	public float timeSincePlayerLocationKnown = float.PositiveInfinity;
	public float playerMinLanternRange;
	public float illuminatedByPlayerMeter;
	public bool hasChokePoint;
	public Vector3 chokePointLocalPosition;
	public Vector3 chokePointLocalFacing;
	public bool reducedFrights_allowChase;
}
