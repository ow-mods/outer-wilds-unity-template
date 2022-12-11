using UnityEngine;

public class PlayerCloneController : MonoBehaviour
{
	[SerializeField]
	private Transform _playerWarpTarget;
	[SerializeField]
	private EndlessCylinder _endlessCylinder;
	[SerializeField]
	private GameObject _playerVisuals;
	[SerializeField]
	private AudioSignal _signal;
	[SerializeField]
	private OWAudioSource _desolateAmbience;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawSphere(base.transform.parent.position, 1f);
	}
}
