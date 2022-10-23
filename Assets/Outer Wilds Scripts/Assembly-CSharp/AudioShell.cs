using UnityEngine;

[AddComponentMenu("Audio/Audio Shell", 300)]
public class AudioShell : SectoredMonoBehaviour
{
	[SerializeField]
	private Transform _audioTransform;
	[SerializeField]
	private float _radius;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = (Gizmos.color = Color.yellow);
		Gizmos.DrawWireSphere(base.transform.position, _radius);
	}
}
