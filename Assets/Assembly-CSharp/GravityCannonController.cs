using UnityEngine;

public class GravityCannonController : MonoBehaviour
{
	[SerializeField]
	private NomaiShuttleController.ShuttleID _shuttleID;
	[SerializeField]
	private ForceVolume _forceVolume;
	[SerializeField]
	private Transform _shuttleSocket;
	[SerializeField]
	private NomaiInterfaceSlot _launchSlot;
	[SerializeField]
	private NomaiInterfaceSlot _retrieveSlot;
	[SerializeField]
	private SingularityWarpEffect _warpEffect;
	[SerializeField]
	private GameObject _recallProxyGeometry;
	[SerializeField]
	private OWTriggerVolume _platformTrigger;
	[Space]
	[SerializeField]
	private OWAudioSource _ambientAudioSrc;
	[SerializeField]
	private OWAudioSource _oneShotAudioSrc;
	[SerializeField]
	private float _fadeLength = 0.5f;
	[Space]
	[SerializeField]
	private NomaiComputer _nomaiComputer;
	[SerializeField]
	private string _retrieveShipLogFact;
	[SerializeField]
	private string _launchShipLogFact;
}
