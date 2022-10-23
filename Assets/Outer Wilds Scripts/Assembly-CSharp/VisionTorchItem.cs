using UnityEngine;

public class VisionTorchItem : OWItem
{
	[SerializeField]
	private MindProjectorTrigger _mindProjectorTrigger;
	[SerializeField]
	private MindSlideProjector _mindSlideProjector;
	[SerializeField]
	private Transform _visionBeam;
	[Space]
	[SerializeField]
	private OWRenderer[] _worldModelRenderers = new OWRenderer[0];
	[SerializeField]
	private OWRenderer[] _viewModelRenderers = new OWRenderer[0];
}
