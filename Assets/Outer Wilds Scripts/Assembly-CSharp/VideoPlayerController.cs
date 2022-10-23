using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class VideoPlayerController : SectoredMonoBehaviour
{
	[SerializeField]
	private AudioSource _audioSource;
	[SerializeField]
	private string _streamingVideoFileName;
	[SerializeField]
	private AudioType _splitAudioType;
}
