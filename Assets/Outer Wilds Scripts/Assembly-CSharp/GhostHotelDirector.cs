using UnityEngine;

public class GhostHotelDirector : GhostDirector
{
	[Space]
	[SerializeField]
	private DreamObjectProjector _hotelProjector;
	[SerializeField]
	private OWAudioSource _ghostHowlAudioSource;
	[SerializeField]
	private OWTriggerVolume _depthsExtensionTrigger;
	[Space]
	[SerializeField]
	private GhostBrain[] _hotelDepthsGhosts = new GhostBrain[0];
	[Header("Theater Ghost")]
	[SerializeField]
	private GhostEffects _theaterGhostEffects;
	[SerializeField]
	private LightSensor _theaterScreenSensor;
	[SerializeField]
	private AutoSlideProjector _slideProjector;
	[SerializeField]
	private GameObject _raycastBlocker;
	[Header("Cafe Ghost")]
	[SerializeField]
	private GhostBrain _cafeGhost;
	[SerializeField]
	private GhostNode.NodeLayer _cafeHiddenNodeLayer = GhostNode.NodeLayer.Purple;
	[SerializeField]
	private GhostNode.NodeLayer _cafeEntranceNodeLayer = GhostNode.NodeLayer.Green;
	[SerializeField]
	private GhostNode.NodeLayer _cafeInteriorNodeLayer = GhostNode.NodeLayer.Orange;
	[SerializeField]
	private OWTriggerVolume _depthsVolume;
	[SerializeField]
	private DreamObjectProjector _bridgeProjector;
}
