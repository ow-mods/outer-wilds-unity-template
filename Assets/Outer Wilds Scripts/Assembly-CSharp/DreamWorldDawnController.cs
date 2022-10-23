using UnityEngine;

public class DreamWorldDawnController : SectoredMonoBehaviour
{
	[SerializeField]
	private OWRenderer _renderer;
	[SerializeField]
	private AnimationCurve _brightnessCurve = AnimationCurve.EaseInOut(0f, 0f, 25f, 1f);
}
