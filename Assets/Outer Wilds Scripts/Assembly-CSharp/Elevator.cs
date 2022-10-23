using UnityEngine;

public class Elevator : MonoBehaviour
{
	[SerializeField]
	private float _trackHeight = 10f;
	[SerializeField]
	private float _trackDepth;
	[SerializeField]
	private float _liftDuration = 3f;
	[SerializeField]
	private Animator _animator;
	[SerializeField]
	private OWAudioSource _owAudioSourceLP;
	[SerializeField]
	private OWAudioSource _owAudioSourceOneShot;
	[SerializeField]
	private OWTriggerVolume[] _killTriggers;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawLine(base.transform.position, base.transform.position + base.transform.up * _trackHeight);
		Gizmos.DrawLine(base.transform.position, base.transform.position - base.transform.up * _trackDepth);
	}
}
