using UnityEngine;

[AddComponentMenu("Streaming/Title Screen Streaming", 200)]
public class TitleScreenStreaming : MonoBehaviour
{
	[SerializeField]
	private string _preloadSceneName = "TimberHearth";
	[SerializeField]
	private StreamingMaterialTable[] _preloadStreamingMaterialTables = new StreamingMaterialTable[0];
}
