using UnityEngine;

[RequireComponent(typeof(LightSensor))]
public class LanternGrapplePoint2 : MonoBehaviour
{
	[SerializeField]
	private float _arrivalDistance = 5f;
	[SerializeField]
	private float _arrivalHeight;
	[SerializeField]
	private TransformAnimator _animator;
	[SerializeField]
	private AnimationCurve _speedCurve;
	[SerializeField]
	private AnimationCurve _fovCurve;
	[Space]
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private PlayerAttachPoint _attachPoint;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(base.transform.position, _arrivalDistance);
	}
}
