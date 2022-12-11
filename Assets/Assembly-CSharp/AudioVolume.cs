using UnityEngine;

[AddComponentMenu("Audio/Audio Volume", 400)]
[RequireComponent(typeof(OWAudioSource))]
public class AudioVolume : PriorityVolume
{
	[Space(10f)]
	[SerializeField]
	protected float _fadeSeconds = 2f;
	[SerializeField]
	protected bool _noFadeFromBeginning;
	[SerializeField]
	protected bool _randomizePlayhead;
	[SerializeField]
	protected bool _pauseOnFadeOut;
	[SerializeField]
	protected OWTriggerVolume _triggerVolumeOverride;
}
