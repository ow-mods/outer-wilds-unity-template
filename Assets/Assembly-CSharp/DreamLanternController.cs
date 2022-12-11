using UnityEngine;

public class DreamLanternController : MonoBehaviour
{
	[SerializeField]
	private float _minRange = 8f;
	[SerializeField]
	private float _maxRange = 30f;
	[SerializeField]
	private float _minAngle = 30f;
	[SerializeField]
	private float _maxAngle = 130f;
	[Space]
	[SerializeField]
	private GameObject _worldModelGroup;
	[SerializeField]
	private GameObject _viewModelGroup;
	[SerializeField]
	private OWLight2 _light;
	[SerializeField]
	private OWRenderer[] _flameRenderers = new OWRenderer[0];
	[SerializeField]
	private OWLight2[] _flameLights = new OWLight2[0];
	[SerializeField]
	private LensFlare _lensFlare;
	[SerializeField]
	private LightFlicker2 _flicker;
	[Space]
	[SerializeField]
	private Transform _focuserGroup;
	[SerializeField]
	private Transform[] _focuserPetals = new Transform[0];
	[SerializeField]
	private Transform[] _concealerRoots = new Transform[0];
	[SerializeField]
	private Transform[] _concealerCovers = new Transform[0];
	[SerializeField]
	private Transform[] _concealerCoversVMPrepass = new Transform[0];
	[SerializeField]
	private Vector3[] _concealerCoverTargets = new Vector3[0];
	[Space]
	[SerializeField]
	private GameObject _simLightConeUnfocused;
	[SerializeField]
	private GameObject _simLightConeFocused;
}
