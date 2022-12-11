using UnityEngine;

public class SunController : MonoBehaviour
{
	[Header("References")]
	[SerializeField]
	private ReferenceFrameVolume _rfVolume;
	[SerializeField]
	private Light _ambientLight;
	[SerializeField]
	private LODGroup _atmosphere;
	[SerializeField]
	private PlanetaryFogController _fog;
	[SerializeField]
	private ShockLayerRuleset _shockLayerRuleset;
	[SerializeField]
	private TessellatedSphereRenderer _surface;
	[SerializeField]
	private Transform _scaledVolumesRoot;
	[SerializeField]
	private SolarFlareEmitter _solarFlareEmitter;
	[SerializeField]
	private SunLightController _sunLight;
	[SerializeField]
	private SupernovaEffectController _supernova;
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private Transform _lightShaftRoot;
	[Header("Progression ")]
	[SerializeField]
	private float _progressionStartTime = 1f;
	[SerializeField]
	private float _progressionEndTime = 19f;
	[Space]
	[SerializeField]
	private float _endScale = 2f;
	[SerializeField]
	private float _fogEndRadius = 4250f;
	[SerializeField]
	private float _fogEndFadeDistance = 250f;
	[SerializeField]
	private float _scaleStartTime = 10f;
	[SerializeField]
	private float _scaleEndTime = 19f;
	[Space]
	[SerializeField]
	private Gradient _atmosphereColor = new Gradient();
	[Space]
	[SerializeField]
	private Material _startSurfaceMaterial;
	[SerializeField]
	private Material _endSurfaceMaterial;
	[Space]
	[SerializeField]
	private Gradient _solarFlareTint = new Gradient();
	[Space]
	[SerializeField]
	private float _endLightIntensity = 0.5f;
	[SerializeField]
	private Gradient _lightColor = new Gradient();
	[Header("Collapse")]
	[SerializeField]
	private float _collapseLength = 10f;
	[SerializeField]
	private float _collapsedScale = 0.1f;
	[Space]
	[SerializeField]
	private ParticleSystem[] _collapseParticles = new ParticleSystem[0];
	[Space]
	[SerializeField]
	private Gradient _collapseAtmosphereColor = new Gradient();
	[Space]
	[SerializeField]
	private Material _collapseTransitionMaterial;
	[SerializeField]
	private Material _collapseStartSurfaceMaterial;
	[SerializeField]
	private Material _collapseEndSurfaceMaterial;
	[Header("Supernova")]
	[SerializeField]
	private Color _lightBlastColor = Color.white;
	[SerializeField]
	private AnimationCurve _lightFlareCurve;
}
