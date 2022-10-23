using UnityEngine;

[AddComponentMenu("Audio/Audio Signal Detection Trigger", 400)]
[RequireComponent(typeof(OWTriggerVolume))]
public class AudioSignalDetectionTrigger : MonoBehaviour
{
	[SerializeField]
	private AudioSignal _signal;
	[SerializeField]
	private bool _allowUnderwater;
	[SerializeField]
	private bool _inDarkZone;
}
