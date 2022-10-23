using UnityEngine;

public class GlitchedCodeDoorInterface : PictureFrameDoorInterface
{
	[Space]
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private OWAudioSource _loopingAudio;
	[SerializeField]
	private Transform[] _simulationTransforms;
}
