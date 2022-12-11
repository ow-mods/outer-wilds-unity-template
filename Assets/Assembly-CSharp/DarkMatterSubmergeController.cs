using UnityEngine;

public class DarkMatterSubmergeController : SectoredMonoBehaviour
{
	[SerializeField]
	private bool _activeWhenSubmerged;
	[Space]
	[SerializeField]
	private EffectVolume[] _effectVolumes = new EffectVolume[0];
	[SerializeField]
	private OWRenderer[] _renderers = new OWRenderer[0];
	[Header("Sensors")]
	[SerializeField]
	private ConstantFluidDetector _fluidDetector;
	[SerializeField]
	private RingRiverFloodSensor _floodSensor;
}
