using UnityEngine;

public class SarcophagusController : MonoBehaviour
{
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private AudioVolume _quietAudioVolume;
	[Header("Mind Projector")]
	[SerializeField]
	private MindProjectorTrigger _mindProjector;
	[SerializeField]
	private OWTriggerVolume _mindProjectorDisableVolume;
	[Header("Seals")]
	[SerializeField]
	private DreamObjectProjector _firstSealProjector;
	[SerializeField]
	private DreamObjectProjector _secondSealProjector;
	[SerializeField]
	private DreamObjectProjector _thirdSealProjector;
	[SerializeField]
	private DreamObjectProjection[] _sealProjections = new DreamObjectProjection[0];
	[SerializeField]
	private Animation _sarcophagusAnimation;
	[SerializeField]
	private bool _debugUnlock;
	[Header("Secret Tunnel")]
	[SerializeField]
	private OWTriggerVolume _tunnelSwapVolume;
	[SerializeField]
	private OWTriggerVolume _tunnelEntrywayTrigger;
	[SerializeField]
	private OWRenderer[] _sarcoBackRenderers = new OWRenderer[0];
	[SerializeField]
	private OWCollider[] _sarcoBackColliders = new OWCollider[0];
	[SerializeField]
	private OWRenderer[] _tunnelRenderers = new OWRenderer[0];
	[SerializeField]
	private OWCollider[] _tunnelColliders = new OWCollider[0];
	[SerializeField]
	private OWRenderer[] _sarcoBackFade = new OWRenderer[0];
	[SerializeField]
	private float _sarcoBackFadeStartDist = 2f;
	[SerializeField]
	private float _sarcoBackFadeEndDist = 1f;
}
