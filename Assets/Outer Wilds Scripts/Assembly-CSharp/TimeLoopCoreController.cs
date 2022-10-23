using UnityEngine;

public class TimeLoopCoreController : MonoBehaviour
{
	[SerializeField]
	private AudioVolume _musicVolume;
	[SerializeField]
	private OWAudioSource _coreCasingAudio;
	[SerializeField]
	private NomaiInterfaceSlot _openSlot;
	[SerializeField]
	private WarpCoreSocket _warpCoreSocket;
	[SerializeField]
	private TransformAnimator[] _panelAnimators;
	[Space(10f)]
	[SerializeField]
	private SingularityController _blackHoleEffect;
	[SerializeField]
	private EffectVolume _attractVolume;
	[SerializeField]
	private TimeLoopBlackHoleVolume _timeLoopBlackHoleVolume;
	[SerializeField]
	private TimeLoopLightController _timeLoopLightController;
	[Space(10f)]
	[SerializeField]
	private GameObject[] _dataStreamObjects;
	[SerializeField]
	private OWAudioSource _dataStreamAudio;
	[Space(10f)]
	[SerializeField]
	private Renderer _chamberDestructionEffect;
	[Space(10f)]
	[SerializeField]
	private TravelerController _duplicatePlayer;
	[SerializeField]
	private SurveyorProbe _duplicateProbe;
	[SerializeField]
	private Transform _duplicateProbeSocket;
}
