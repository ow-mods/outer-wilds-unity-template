using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimController : MonoBehaviour
{
	[SerializeField]
	private GameObject _unsuitedGroup;
	[SerializeField]
	private GameObject _suitedGroup;
	[SerializeField]
	private GameObject[] _rightArmObjects;
	[SerializeField]
	private AnimatorOverrideController _unsuitedAnimOverride;

	private void OnDrawGizmosSelected()
	{
		var animator = GetComponent<Animator>();
		if (animator != null)
		{
			Transform leftToesTransform = animator.GetBoneTransform(HumanBodyBones.LeftToes);
			if (leftToesTransform != null)
			{
				Gizmos.color = Color.red;
				OWGizmos.DrawWireArc(leftToesTransform.position, base.transform.up, base.transform.forward, -180f, 0.25f);
			}
			Transform rightToesTransform = animator.GetBoneTransform(HumanBodyBones.RightToes);
			if (rightToesTransform != null)
			{
				Gizmos.color = Color.red;
				OWGizmos.DrawWireArc(rightToesTransform.position, base.transform.up, base.transform.forward, 180f, 0.25f);
			}
		}
	}
}
