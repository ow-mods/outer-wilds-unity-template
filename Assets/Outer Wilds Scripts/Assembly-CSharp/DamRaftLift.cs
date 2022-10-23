using UnityEngine;

public class DamRaftLift : RaftCarrier
{
	[SerializeField]
	private Transform[] _liftNodes = new Transform[0];
	[SerializeField]
	private Transform _craneRoot;
	[SerializeField]
	private Transform[] _craneWheels = new Transform[0];
	[SerializeField]
	private float _hookReturnSpeed = 8f;
	[SerializeField]
	private float _craneReturnSpeed = 5f;
	[SerializeField]
	private RaftDockLights _raftDockLights;
	[SerializeField]
	private OWRenderer[] _hookRenderers = new OWRenderer[0];

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.green;
		for (int i = 0; i < _liftNodes.Length; i++)
		{
			if (_liftNodes[i] == null) continue;
			Gizmos.DrawSphere(_liftNodes[i].position, 1f);
			if (_liftNodes.Length > i + 1)
			{
				Gizmos.DrawLine(_liftNodes[i].position, _liftNodes[i + 1].position);
			}
		}
	}
}
