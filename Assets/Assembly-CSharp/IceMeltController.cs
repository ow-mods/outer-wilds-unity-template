using UnityEngine;

public class IceMeltController : MonoBehaviour
{
	[SerializeField]
	private float _startMeltDistance = 1000f;
	[SerializeField]
	private float _endMeltDistance = 500f;
	[Space]
	[SerializeField]
	private Transform _surfaceIce;
	[SerializeField]
	private Transform _surfaceIceProxy;
	[SerializeField]
	private float _surfaceIceMeltedScale = 0.9f;
	[Space]
	[SerializeField]
	private SkinnedMeshRenderer _crackIce;
	[SerializeField]
	private AnimationCurve[] _blendWeightCurves = new AnimationCurve[0];
	[SerializeField]
	private Transform[] _crackIceColliders;
	[SerializeField]
	private AnimationCurve _colliderScaleCurve = AnimationCurve.EaseInOut(0f, 1f, 1f, 0f);
	[Space]
	[SerializeField]
	private AudioVolume _audioVolume;
}
