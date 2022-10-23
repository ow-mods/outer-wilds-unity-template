using UnityEngine;

public class ThrusterAudio : MonoBehaviour
{
	[SerializeField]
	protected OWAudioSource _translationalSource;
	[SerializeField]
	private OWAudioSource _rotationalSource;
	[Space]
	[SerializeField]
	protected AudioType _rotationClip;
	[SerializeField]
	protected AudioType _underwaterRotationClip;
}
