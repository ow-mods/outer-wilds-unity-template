using UnityEngine;

[RequireComponent(typeof(Animator))]
public class SolanumAnimController : MonoBehaviour
{
	[SerializeField]
	private DampedSpringQuat _lookSpring = new DampedSpringQuat();
	[SerializeField]
	private GameObject _staffLocked;
	[SerializeField]
	private GameObject _staffUnlocked;
	[SerializeField]
	private OWAudioSource _symbolsAudioSource;
	[SerializeField]
	private OWAudioSource _foleyAudioSource;
}
