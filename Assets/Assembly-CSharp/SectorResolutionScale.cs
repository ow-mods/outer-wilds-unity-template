using UnityEngine;

public class SectorResolutionScale : SectoredMonoBehaviour
{
	[Header("Per-Platform Target Resolutions")]
	[SerializeField]
	private DynamicResolutionManager.TargetResolution _xboxOne = DynamicResolutionManager.TargetResolution.Full;
	[SerializeField]
	private DynamicResolutionManager.TargetResolution _xboxOneS = DynamicResolutionManager.TargetResolution.Full;
	[SerializeField]
	private DynamicResolutionManager.TargetResolution _xboxOneX = DynamicResolutionManager.TargetResolution.Full;
	[SerializeField]
	private DynamicResolutionManager.TargetResolution _playstation4 = DynamicResolutionManager.TargetResolution.Full;
	[SerializeField]
	private DynamicResolutionManager.TargetResolution _playstation4Pro = DynamicResolutionManager.TargetResolution.Full;
	[SerializeField]
	private DynamicResolutionManager.TargetResolution _xboxSeriesS = DynamicResolutionManager.TargetResolution.Full;
	[SerializeField]
	private DynamicResolutionManager.TargetResolution _xboxSeriesX = DynamicResolutionManager.TargetResolution.Full;
	[SerializeField]
	private DynamicResolutionManager.TargetResolution _playstation5 = DynamicResolutionManager.TargetResolution.Full;
}
