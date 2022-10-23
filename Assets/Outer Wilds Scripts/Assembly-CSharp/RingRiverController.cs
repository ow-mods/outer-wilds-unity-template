using UnityEngine;

public class RingRiverController : MonoBehaviour
{
	[SerializeField]
	private bool _debugToggleFlood;
	[HideInInspector]
	[SerializeField]
	private float _debugFloodLerp;
	[Space]
	[SerializeField]
	private TessellatedRingRenderer _river;
	[SerializeField]
	private OWRingRiverCollider _riverCollider;
	[SerializeField]
	private EffectRuleset _underwaterEffectRuleset;
	[SerializeField]
	private RingWaveAudioController _waveAudio;
}
