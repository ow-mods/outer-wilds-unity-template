using UnityEngine;

[AddComponentMenu("Streaming/Streaming Mesh Handle", 300)]
public class StreamingMeshHandle : MonoBehaviour
{
	[SerializeField]
	public string assetBundle;
	[SerializeField]
	public int meshIndex;
	[SerializeField]
	public Mesh proxyMesh;
}
