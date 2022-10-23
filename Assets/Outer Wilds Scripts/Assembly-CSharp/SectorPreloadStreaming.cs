using UnityEngine;

[AddComponentMenu("Streaming/Sector Preload Streaming", 200)]
public class SectorPreloadStreaming : MonoBehaviour
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private string _preloadSceneName = "";
}
