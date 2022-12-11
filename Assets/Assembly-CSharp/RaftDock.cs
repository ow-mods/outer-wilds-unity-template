using UnityEngine;

public class RaftDock : RaftCarrier
{
	[SerializeField]
	private RaftController _startRaft;
	[Space]
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private GearInterfaceEffects _gearInterface;
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
	[SerializeField]
	private Transform _raftSocket;
	[SerializeField]
	private OWTriggerVolume _raftDetectorVolume;
	[SerializeField]
	private RaftDockLights _lightsController;
	[Header("Raft Proxy Collision")]
	[SerializeField]
	private Transform _raftProxyColliderRoot;
	[SerializeField]
	private OWCollider[] _raftProxyColliders;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.matrix = Matrix4x4.TRS(base.transform.position, base.transform.rotation, Vector3.one);
		Gizmos.DrawWireCube(Vector3.zero, new Vector3(6f, 1f, 6f));
	}
}
