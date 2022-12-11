using UnityEngine;
using UnityEngine.Serialization;

public class Signalscope : PlayerTool
{
	[FormerlySerializedAs("_zoomModeUI")]
	[SerializeField]
	private SignalscopeUI _signalscopeUI;
	[SerializeField]
	private SignalscopeAudioController _signalscopeAudio;
	[SerializeField]
	private GameObject _scopeGameObject;
}
