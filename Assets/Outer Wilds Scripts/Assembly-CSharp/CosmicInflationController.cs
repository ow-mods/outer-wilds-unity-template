using UnityEngine;

public class CosmicInflationController : MonoBehaviour
{
	[SerializeField]
	private QuantumCampsiteController _campsiteController;
	[Space]
	[SerializeField]
	private float _sphereInflationDuration = 0.6f;
	[SerializeField]
	private float _sphereInflationDelay = 5f;
	[SerializeField]
	private float _bigBangParticlesPlayOffset;
	[SerializeField]
	private float _bigBangParticlesCutoffTime = 6f;
	[SerializeField]
	private float _bigBangIgniteDelay;
	[SerializeField]
	private float _bigBangAudioDelay;
	[SerializeField]
	private float _bigBangHelmetCrackDelay;
	[SerializeField]
	private float _bigBangMusicDelay = 0.7f;
	[SerializeField]
	private float _inflationScale = 340f;
	[SerializeField]
	private float _postInflationRate = 0.115f;
	[Space]
	[SerializeField]
	private AnimationCurve _inflationCurve;
	[SerializeField]
	private AnimationCurve _sphereCurve;
	[Space]
	[SerializeField]
	private ParticleSystem[] _smokeSphereParticles;
	[SerializeField]
	private ParticleSystem[] _inflationParticles;
	[SerializeField]
	private ParticleSystem[] _bigBangParticles;
	[SerializeField]
	private OWRenderer[] _smokeStreamRenderers;
	[Space]
	[SerializeField]
	private bool _inflateOnButtonPress;
	[SerializeField]
	private OWAudioSource _musicSource;
	[SerializeField]
	private OWAudioSource _sfxSource;
	[SerializeField]
	private OWAudioSource _travelerFinaleSource;
	[SerializeField]
	private TravelerEyeController[] _travelers;
	[SerializeField]
	private Campfire _campfire;
	[SerializeField]
	private PossibilitySphereController _possibilitySphereController;
	[SerializeField]
	private Transform _possibilitySphereRoot;
	[SerializeField]
	private Transform _inflationSphereRoot;
	[SerializeField]
	private FluidVolume _repelVolume;
	[Header("Post Collapse")]
	[SerializeField]
	private Transform _playerPostCollapseSocket;
	[SerializeField]
	private Transform _altPlayerPostCollapseSocket;
	[SerializeField]
	private GameObject _altTravelerToHidePostCollapse;
	[Space]
	[SerializeField]
	private OWLight _inflationLight;
	[SerializeField]
	private Transform[] _inflationObjects;
	[SerializeField]
	private GameObject[] _activateOnInflation;
	[SerializeField]
	private GameObject[] _deactivateOnInflation;
	[SerializeField]
	private GameObject[] _deactivateAfterInflationLightFades;
	[SerializeField]
	private OWRenderer[] _groundRenderers;
	[Space]
	[SerializeField]
	private TessellatedSphereRenderer _bigBangRenderer;
	[SerializeField]
	private Material _endBigBangMaterial;
	[SerializeField]
	private GameObject _lightShafts;
	[SerializeField]
	[ColorUsage(false, true)]
	private Color _bigBangStartColor;
	[SerializeField]
	[ColorUsage(false, true)]
	private Color _bigBangEndColor;
	[Space]
	[SerializeField]
	private ForceVolume _gravityVolume;
	[SerializeField]
	private EndlessCylinder _endlessCylinder;
	[SerializeField]
	private OWTriggerVolume _smokeSphereTrigger;
	[SerializeField]
	private OWTriggerVolume _probeDestroyTrigger;
	[SerializeField]
	private OWTriggerVolume _bigBangTrigger;
	[SerializeField]
	private InteractReceiver _interactReceiver;
}
