using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
	public enum CreditsType
	{
		Final = 1,
		Fast = 4,
		Krazy = 8,
		All = int.MaxValue,
	}

	public enum Platform
	{
		Nothing = 0,
		Epic = 2,
		Steam = 4,
		PS4 = 8,
		XBoxOne = 16,
		Switch = 32,
		PS5 = 64,
		XBoxSeriesS = 128,
		XBoxSeriesX = 256,
		XBoxSeriesSX = 384,
		Sony = 72,
		Microsoft = 400,
		Nintendo = 32,
		PC = 6,
		All = int.MaxValue,
	}

	[SerializeField]
	private CreditsType _type;
	[SerializeField]
	private CreditsAsset _creditsAsset;
	[Space]
	[SerializeField]
	private AnimationCurve _fadeFromWhiteCurve;
	[SerializeField]
	private Image _fadeImage;
	[SerializeField]
	private float _whiteFadeDuration = 0.5f;
	[SerializeField]
	private OWAudioSource _musicSource;
	[SerializeField]
	private OWAudioSource _kazooSource;
	[SerializeField]
	private AudioClip _previewClip;
	[SerializeField]
	[HideInInspector]
	private float _totalPlayTime;
	[SerializeField]
	[HideInInspector]
	private float _simulatedTimeNormalized;
	[SerializeField]
	[HideInInspector]
	private Platform _simulatePlatform;
}
