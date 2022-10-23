using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "StreamingTextureCollectionTable", menuName = "Streaming Texture Collection Table", order = 651)]
public class StreamingTextureCollectionTable : ScriptableObject
{
	[SerializeField]
	public string assetBundle;
}
