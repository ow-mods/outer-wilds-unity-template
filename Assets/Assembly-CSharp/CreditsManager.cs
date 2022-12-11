using UnityEngine;
using UnityEngine.UI;

public class CreditsManager : MonoBehaviour
{
	[SerializeField]
	private bool _finalCredits;
	[SerializeField]
	private AnimationCurve _fadeCurve;
	[Space]
	[SerializeField]
	private AnimationCurve _fadeFromWhiteCurve;
	[SerializeField]
	private Image _fadeImage;
	[SerializeField]
	private float _fadeLength = 0.5f;
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private OWAudioSource _kazooSource;
}
