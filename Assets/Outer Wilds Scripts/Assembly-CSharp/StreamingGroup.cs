using UnityEngine;

[AddComponentMenu("Streaming/Streaming Group", 100)]
public class StreamingGroup : MonoBehaviour
{
	[SerializeField]
	private string _sceneName = "";
	[SerializeField]
	private StreamingMaterialTable[] _streamingMaterialTables = new StreamingMaterialTable[0];
	[SerializeField]
	private bool _reloadAssetsOnDeath;
}
