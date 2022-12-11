using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CharacterAnimController : SectoredMonoBehaviour
{
	[SerializeField]
	private Animator _secondaryAnimator;
	[SerializeField]
	protected CharacterDialogueTree _dialogueTree;
	[Space]
	public OWTriggerVolume playerTrackingZone;
	public DampedSpring3D lookSpring = new DampedSpring3D();
	public bool lookOnlyWhenTalking = true;
	public float headTrackingWeight = 1f;
	[Space]
	[SerializeField]
	protected float _blinksPerMinute = 15f;
	[SerializeField]
	protected float _blinkDuration = 0.05f;
	[SerializeField]
	protected BlinkBlendshape _blinkStyle;
	[SerializeField]
	protected SkinnedMeshRenderer _skinRenderer;
	[Space]
	[SerializeField]
	protected bool _hasTalkAnimation;
}
