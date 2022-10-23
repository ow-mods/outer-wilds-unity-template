using UnityEngine;

public class DreamLanternItem : OWItem
{
	[SerializeField]
	private DreamLanternType _lanternType = DreamLanternType.Functioning;
	[SerializeField]
	private bool _startLit;
	[Space]
	[SerializeField]
	private FluidDetector _fluidDetector;
	[SerializeField]
	private OWAudioSource _oneShotSource;
}
