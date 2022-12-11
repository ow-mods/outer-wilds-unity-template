using UnityEngine;

[AddComponentMenu("Streaming/Nomai Warp Streaming", 200)]
[RequireComponent(typeof(OWTriggerVolume))]
public class NomaiWarpStreaming : SectoredMonoBehaviour
{
	[SerializeField]
	private string _destinationSceneName = "";
	[Space]
	[SerializeField]
	private NomaiWarpTransmitter _warpTransmitter;
	[SerializeField]
	private float _streamingAngle = 15f;
	[Space]
	[SerializeField]
	private NomaiWarpReceiver _warpReceiver;
}
