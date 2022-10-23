using UnityEngine;

public class RiverPathAudioSource : MonoBehaviour
{
	[SerializeField]
	private OWAudioSource[] _audioPool;
	[Space]
	[SerializeField]
	private float _muffledVolume = 0.2f;
	[SerializeField]
	private float _crossfadeInDuration = 2f;
	[SerializeField]
	private float _crossfadeOutDuration = 3f;
	[SerializeField]
	private float _crossfadeThreshold = 10f;
	[SerializeField]
	private float _minShoreFollowSpeed = 10f;
}
