using UnityEngine;

public class RiverPathAudioController : MonoBehaviour
{
	[SerializeField]
	private BaseRiverAudioPath _path;
	[SerializeField]
	private OWTriggerVolume _activationVolume;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawSphere(base.transform.position, 0.5f);
	}
}
