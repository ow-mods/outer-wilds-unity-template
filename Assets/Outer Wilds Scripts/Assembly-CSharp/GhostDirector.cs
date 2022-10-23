using UnityEngine;

public class GhostDirector : MonoBehaviour
{
	[SerializeField]
	protected Sector _sector;
	[SerializeField]
	protected DreamArrivalPoint _dreamArrivalPoint;
	[SerializeField]
	protected GhostBrain[] _directedGhosts = new GhostBrain[0];
	[SerializeField]
	protected bool _startAwake = true;
	[Space]
	[SerializeField]
	private OWAudioSource _ghostGroupDeathAudioSource;
}
