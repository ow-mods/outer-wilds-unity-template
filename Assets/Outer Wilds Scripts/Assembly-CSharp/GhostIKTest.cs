using UnityEngine;

public class GhostIKTest : MonoBehaviour
{
	[SerializeField]
	private OWIK _leftFootIK;
	[SerializeField]
	private OWIK _rightFootIK;
	[SerializeField]
	private Vector3 _feetPlacementOffset;
	[SerializeField]
	[Range(0f, 0.99f)]
	private float _footIKDampening;
	[SerializeField]
	private float _maxFootVerticalDistance;
	[SerializeField]
	private float strideLength;
	[SerializeField]
	private float _strideArcHeight;
	[SerializeField]
	private bool _adjustRootY;
	[SerializeField]
	private Transform _worldRef;
	[SerializeField]
	private Transform _torsoGoalPivot;

	private void OnDrawGizmos()
	{
		var animator = GetComponent<Animator>();
		if (animator != null)
		{
			Transform boneTransform = animator.GetBoneTransform(HumanBodyBones.LeftToes);
			Transform boneTransform2 = animator.GetBoneTransform(HumanBodyBones.RightToes);
			Transform boneTransform3 = animator.GetBoneTransform(HumanBodyBones.LeftFoot);
			Transform boneTransform4 = animator.GetBoneTransform(HumanBodyBones.RightFoot);
			Gizmos.color = Color.cyan;
			Gizmos.DrawSphere(boneTransform.position, 0.05f);
			Gizmos.DrawSphere(boneTransform2.position, 0.05f);
			Gizmos.color = Color.red;
			Gizmos.DrawSphere(boneTransform3.position, 0.05f);
			Gizmos.DrawSphere(boneTransform4.position, 0.05f);
			Transform boneTransform5 = animator.GetBoneTransform(HumanBodyBones.Hips);
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(boneTransform5.position, 0.2f);
		}
	}
}
