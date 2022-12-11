using UnityEngine;

public class PlayerCameraEffectController : MonoBehaviour
{
	[Header("Damage Effects")]
	[SerializeField]
	private float _winceFadeLength = 1f;
	[SerializeField]
	private AnimationCurve _winceEffectCurve = AnimationCurve.Linear(0f, 1f, 1f, 0f);
	[SerializeField]
	private AnimationCurve _winceExposure = AnimationCurve.Linear(0f, 0f, 100f, 1f);
	[SerializeField]
	private AnimationCurve _winceSaturation = AnimationCurve.Linear(0f, 1f, 100f, 0f);
	[SerializeField]
	private AnimationCurve _winceContrast = AnimationCurve.Linear(0f, 1f, 100f, 2f);
	[SerializeField]
	private float _phospheneFadeLength = 5f;
	[SerializeField]
	private AnimationCurve _phospheneBrightness = AnimationCurve.Linear(0f, 1f, 1f, 0f);
	[Header("Start Effects")]
	[SerializeField]
	private float _wakeLength = 2f;
	[SerializeField]
	private AnimationCurve _fastWakeCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	[SerializeField]
	private AnimationCurve _calmWakeCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	[Header("Death Effects")]
	[SerializeField]
	private float _defaultDeathFadeLength = 0.3f;
	[SerializeField]
	private float _impactSlowFadeLength = 5f;
	[SerializeField]
	private float _suicideSlowFadeLength = 5f;
	[SerializeField]
	private AnimationCurve _impactSlowCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	[SerializeField]
	private float _impactQuickFadeLength = 0.3f;
	[SerializeField]
	private float _impactQuickDeathSpeed = 100f;
	[SerializeField]
	private float _asphyxiationFadeLength = 5f;
	[SerializeField]
	private float _energyFadeLength = 1f;
	[SerializeField]
	private float _bigBangFadeLength = 5f;
	[SerializeField]
	private float _digestionFadeLength = 5f;
	[SerializeField]
	private float _timeLoopFadeLength = 2f;
	[SerializeField]
	private Texture2D _timeLoopEyeMask;
	[SerializeField]
	private float _timeLoopBlendWidth = 0.1f;
	[SerializeField]
	private AnimationCurve _timeLoopEyeMaskCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	[SerializeField]
	private AnimationCurve _timeLoopLinesProgressionCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	[SerializeField]
	private float _escapeTimeLoopFadeLength = 5f;
	[SerializeField]
	private float _blackHoleFadeLength = 0.5f;
	[SerializeField]
	private float _realityShatterLength = 1f;
	[SerializeField]
	private float _dreamFadeLength = 0.5f;
	[SerializeField]
	private AnimationCurve _realityShardShatterCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	[SerializeField]
	private AnimationCurve _realityShardOffsetCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	[SerializeField]
	private AnimationCurve _realityShardDissolveWidthCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	[SerializeField]
	private AnimationCurve _realityShardDissolveProgressCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
}
