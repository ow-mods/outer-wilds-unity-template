using UnityEngine;

[AddComponentMenu("Streaming/Dream Campfire Streaming", 200)]
public class DreamCampfireStreaming : SectoredMonoBehaviour
{
	[SerializeField]
	private OWTriggerVolume _streamingVolume;
	[SerializeField]
	private DreamCampfire _dreamCampfire;
}
