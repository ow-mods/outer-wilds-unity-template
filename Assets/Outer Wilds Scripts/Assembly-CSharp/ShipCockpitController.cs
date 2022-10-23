using UnityEngine;

public class ShipCockpitController : MonoBehaviour
{
	[SerializeField]
	private ShipLight _headlight;
	[SerializeField]
	private ShipLight _landingLight;
	[SerializeField]
	private ShipLight[] _dimmingLights = new ShipLight[0];
	[SerializeField]
	private float _dimmingLightScale = 0.5f;
	[SerializeField]
	private ProbeLauncher _shipProbeLauncher;
	[SerializeField]
	private PlayerAttachPoint _playerAttachPoint;
	[SerializeField]
	private Collider _cockpitCollider;
	[SerializeField]
	private Collider[] _fogLightOcclusionColliders;
	[SerializeField]
	private ShipCanvasGroup[] _shipCanvases = new ShipCanvasGroup[0];
	[SerializeField]
	private ShipCanvasGroup[] _dashboardCanvases = new ShipCanvasGroup[0];
	[SerializeField]
	private LandingCamera _landingCam;
}
