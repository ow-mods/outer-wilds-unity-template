using UnityEngine;

[AddComponentMenu("Audio/Audio Spread Controller", 300)]
[RequireComponent(typeof(OWAudioSource))]
public class AudioSpreadController : SectoredMonoBehaviour
{
	[SerializeField]
	private float _transitionDistance;
	
	private void OnDrawGizmosSelected()
	{
		AudioSource component = GetComponent<AudioSource>();
		if (component == null) return;
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(base.transform.position, component.minDistance);
		Gizmos.DrawWireSphere(base.transform.position, component.minDistance + _transitionDistance);
	}
}
