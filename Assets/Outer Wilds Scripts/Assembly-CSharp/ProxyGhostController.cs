using UnityEngine;

public class ProxyGhostController : SectoredMonoBehaviour
{
	public enum IdleStyle
	{
		Normal = 0,
		Hunched = 1,
		Twitchy = 2,
		HoldInstrument = 3,
		SkyGaze = 4,
		ShoeGaze = 5,
		Lean = 6,
	}

	[Space]
	[SerializeField]
	private Animator _animator;
	[SerializeField]
	private IdleStyle _idleStyle;
	[SerializeField]
	private GhostEffects.DeathAnimStyle _deathStyle = GhostEffects.DeathAnimStyle.Random;
	[Space]
	[SerializeField]
	private OWAudioSource _voiceAudioSource;
	[SerializeField]
	private OWRenderer[] _dissolveRenderers;
	[SerializeField]
	private OWRenderer[] _ditherRenderers;
	[SerializeField]
	private ParticleSystem _deathParticleSystem;
	[SerializeField]
	private GameObject[] _heldProps = new GameObject[0];
	[SerializeField]
	private Animation[] _heldPropDeathAnimations = new Animation[0];
	[Space]
	[SerializeField]
	private bool _rightHandIK;
	[SerializeField]
	private Transform _rightHandIKTarget;
	[SerializeField]
	private bool _leftHandIK;
	[SerializeField]
	private Transform _leftHandIKTarget;
	[SerializeField]
	private bool _rightFootIK;
	[SerializeField]
	private Transform _rightFootIKTarget;
	[SerializeField]
	private bool _leftFootIK;
	[SerializeField]
	private Transform _leftFootIKTarget;
	[SerializeField]
	private bool _headLook;
	[SerializeField]
	private OWTriggerVolume _headLookTriggerVolume;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject) && !(_animator == null))
		{
			Gizmos.color = Color.red;
			if (_rightHandIK && _rightHandIKTarget != null)
			{
				Gizmos.DrawLine(_animator.GetBoneTransform(HumanBodyBones.RightHand).position, _rightHandIKTarget.position);
				OWGizmos.DrawWireCircle(_rightHandIKTarget.position + _rightHandIKTarget.forward * 0.2f, _rightHandIKTarget.up, 0.2f);
				Gizmos.DrawRay(_rightHandIKTarget.position, _rightHandIKTarget.forward * 0.5f);
			}
			if (_leftHandIK && _leftHandIKTarget != null)
			{
				Gizmos.DrawLine(_animator.GetBoneTransform(HumanBodyBones.LeftHand).position, _leftHandIKTarget.position);
				OWGizmos.DrawWireCircle(_leftHandIKTarget.position + _leftHandIKTarget.forward * 0.2f, _leftHandIKTarget.up, 0.2f);
				Gizmos.DrawRay(_leftHandIKTarget.position, _leftHandIKTarget.forward * 0.5f);
			}
			if (_rightFootIK && _rightFootIKTarget != null)
			{
				Gizmos.DrawLine(_animator.GetBoneTransform(HumanBodyBones.RightFoot).position, _rightFootIKTarget.position);
				OWGizmos.DrawWireCircle(_rightFootIKTarget.position + _rightFootIKTarget.forward * 0.1f, _rightFootIKTarget.up, 0.1f);
				Gizmos.DrawRay(_rightFootIKTarget.position, _rightFootIKTarget.forward * 0.25f);
			}
			if (_leftFootIK && _leftFootIKTarget != null)
			{
				Gizmos.DrawLine(_animator.GetBoneTransform(HumanBodyBones.LeftFoot).position, _leftFootIKTarget.position);
				OWGizmos.DrawWireCircle(_leftFootIKTarget.position + _leftFootIKTarget.forward * 0.1f, _leftFootIKTarget.up, 0.1f);
				Gizmos.DrawRay(_leftFootIKTarget.position, _leftFootIKTarget.forward * 0.25f);
			}
		}
	}
}
