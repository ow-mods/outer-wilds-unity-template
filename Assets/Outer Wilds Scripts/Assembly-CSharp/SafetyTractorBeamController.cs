using UnityEngine;

[RequireComponent(typeof(TractorBeamController))]
public class SafetyTractorBeamController : SectoredMonoBehaviour
{
	[SerializeField]
	private ForceVolume _alignmentForceVolume;
	[SerializeField]
	private Renderer[] _renderers;
	[SerializeField]
	private int _materialIndex;
	[SerializeField]
	private float _fadeDuration = 1f;
}
