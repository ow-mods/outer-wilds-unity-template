using UnityEngine;
using UnityEngine.Serialization;

[AddComponentMenu("Audio/Audio Signal", 400)]
[RequireComponent(typeof(OWAudioSource))]
public class AudioSignal : SectoredMonoBehaviour
{
	[SerializeField]
	private SignalFrequency _frequency = SignalFrequency.Default;
	[SerializeField]
	private SignalName _name;
	[SerializeField]
	private float _sourceRadius;
	[FormerlySerializedAs("_detectionRadius")]
	[SerializeField]
	private float _identificationDistance = 10f;
	[Space]
	[SerializeField]
	private float _waveformScalar = 1f;
	[SerializeField]
	private bool _startActive = true;
	[SerializeField]
	private bool _onlyAudibleToScope;
	[SerializeField]
	private bool _preventIdentification;
	[SerializeField]
	private OuterFogWarpVolume _outerFogWarpVolume;
	[SerializeField]
	private string _revealFactID = "";
	[Space]
	[SerializeField]
	private bool _debug;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = new ColorHSV(50f, 0.82f, 0.5f).ToColorRGB();
			Gizmos.color = Color.green;
			OWGizmos.DrawBillboardedWireCircle(base.transform.position, _sourceRadius + _identificationDistance);
			Gizmos.color = Color.yellow;
			OWGizmos.DrawBillboardedWireCircle(base.transform.position, _sourceRadius);
		}
	}
}
