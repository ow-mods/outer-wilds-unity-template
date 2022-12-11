using UnityEngine;

[AddComponentMenu("Streaming/Linked Sector Streaming", 200)]
public class LinkedSectorStreaming : SectorStreaming
{
	[Space]
	[SerializeField]
	private string _linkedSceneName = "";
}
