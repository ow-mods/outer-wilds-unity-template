using UnityEngine;

public class TractorBeamController : SectoredMonoBehaviour
{
	[SerializeField]
	private bool _deactivateOnAwake;
	[Space(10f)]
	[SerializeField]
	private OWAudioSource _oneShotAudioSrc;
	[SerializeField]
	private Transform _baseTransform;
}
