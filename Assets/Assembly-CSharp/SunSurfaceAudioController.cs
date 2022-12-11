using UnityEngine;

[RequireComponent(typeof(OWAudioSource))]
public class SunSurfaceAudioController : SectoredMonoBehaviour
{
	[SerializeField]
	private SunController _sunController;
	[SerializeField]
	private OWAudioSource _sunStationMusicSource;
	[SerializeField]
	private OWTriggerVolume _sunStationVolume;
}
