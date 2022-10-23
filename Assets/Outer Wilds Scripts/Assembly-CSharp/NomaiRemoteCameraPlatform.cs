using UnityEngine;

public class NomaiRemoteCameraPlatform : NomaiShared
{
	public enum ID
	{
		None = 0,
		SunStation = 1,
		HGT_TimeLoop = 2,
		THM_EyeLocator = 4,
		TH_Mine = 5,
		BH_Observatory = 6,
		BH_GravityCannon = 7,
		BH_QuantumFragment = 8,
		BH_BlackHoleForge = 9,
		GD_ConstructionYardIsland1 = 10,
		GD_ConstructionYardIsland2 = 11,
		GD_StatueIsland = 12,
		GD_ProbeCannonSunkenModule = 13,
		GD_ProbeCannonDamagedModule = 14,
		GD_ProbeCannonIntactModule = 15,
		VM_Interior = 16,
		HGT_TLE = 17,
		BH_NorthPole = 18,
	}

	[SerializeField]
	private string _dataPointID;
	[SerializeField]
	private Sector _visualSector;
	[SerializeField]
	private Sector _visualSector2;
	[SerializeField]
	private Shape _connectionBounds;
	[Space]
	[SerializeField]
	private MeshRenderer _poolRenderer;
	[SerializeField]
	private float _poolFillLength = 3f;
	[SerializeField]
	private float _poolEmptyLength = 0.5f;
	[SerializeField]
	private AnimationCurve _poolHeightCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);
	[SerializeField]
	private AnimationCurve _poolMaskCurve = AnimationCurve.Linear(0f, 1f, 1f, 0f);
	[SerializeField]
	private AnimationCurve _poolWaveHeightCurve = AnimationCurve.EaseInOut(0f, 0.01f, 1f, 0.05f);
	[Space]
	[SerializeField]
	private Renderer[] _transitionRenderers;
	[SerializeField]
	private PedestalAnimator _transitionPedestalAnimator;
	[SerializeField]
	private GameObject _transitionStone;
	[Space]
	[SerializeField]
	private GameObject _hologramGroup;
	[SerializeField]
	private Transform _playerHologram;
	[SerializeField]
	private Transform _stoneHologram;
	[Space]
	[SerializeField]
	private float _fadeInLength = 1.5f;
	[SerializeField]
	private float _fadeOutLength = 0.25f;
	[Space]
	[SerializeField]
	private OWAudioSource _ambientAudioSource;
	[SerializeField]
	private OWAudioSource _oneShotAudioSource;
	[Space]
	[SerializeField]
	private DarkZone _darkZone;
}
