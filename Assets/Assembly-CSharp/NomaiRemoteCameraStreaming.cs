using UnityEngine;

[AddComponentMenu("Streaming/Nomai Remote Camera Streaming", 200)]
[RequireComponent(typeof(OWTriggerVolume))]
public class NomaiRemoteCameraStreaming : SectoredMonoBehaviour
{
	[SerializeField]
	private NomaiRemoteCameraPlatform _remoteCameraPlatform;
}
