using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class PostCreditsManager : MonoBehaviour
{
	[SerializeField]
	private OWCamera _camera;
	[SerializeField]
	private float _fadeInTime = 1f;
	[SerializeField]
	private float _fadeOutTime = 1f;
	[Space]
	[SerializeField]
	private GameObject[] _solanumObjects = new GameObject[0];
	[SerializeField]
	private OWAudioSource _campfireAudio;
	[SerializeField]
	private OWAudioSource _campfireOneShot;
	[SerializeField]
	private OWLightController _campfireLightController;
	[SerializeField]
	private Light _campfirePrimaryLight;
	[SerializeField]
	private Renderer _campfireFlamesRenderer;
	[SerializeField]
	private Renderer _campfireSmokeRenderer;
	[SerializeField]
	private Image[] _campfireLitImages = new Image[0];
	[Space]
	[SerializeField]
	private GameObject[] _prisonerObjects = new GameObject[0];
	[SerializeField]
	private OWAudioSource _ruinsOneShot;
	[SerializeField]
	private AnimationCurve _ruinsLightCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	[SerializeField]
	private Image[] _ruinsLitImages = new Image[0];
	[SerializeField]
	private OWAudioSource _lanternOneShot;
	[SerializeField]
	private AnimationCurve _lanternLightCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	[SerializeField]
	private Image[] _lanternLitImages = new Image[0];
	[Space]
	[SerializeField]
	private GameObject[] _probeObjects = new GameObject[0];
	[SerializeField]
	private Animator _probeAnimator;
	[SerializeField]
	private OWAudioSource _probeAudio;
	[SerializeField]
	private OWAudioSource _musicSource;
	[SerializeField]
	private OWAudioSource _ambientSource;
}
