using UnityEngine;

[AddComponentMenu("Audio/One Shot Audio Trigger", 400)]
[RequireComponent(typeof(OWAudioSource))]
[RequireComponent(typeof(OWTriggerVolume))]
public class OneShotAudioTrigger : MonoBehaviour
{
	[SerializeField]
	private bool _playInShip = true;
}
