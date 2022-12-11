using UnityEngine;

[RequireComponent(typeof(LightSensor))]
public class LanternZoomPoint : SectoredMonoBehaviour
{
	[Space]
	[SerializeField]
	private float _arrivalDistance = 5f;
	[SerializeField]
	private float _minActivationDistance = 10f;
	[SerializeField]
	private AnimationCurve _zoomInCurve;
	[SerializeField]
	private AnimationCurve _retroZoomCurve;
	[Space]
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private PlayerAttachPoint _attachPoint;
	[SerializeField]
	private Animator _totemAnimator;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(base.transform.position, _arrivalDistance);
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireSphere(base.transform.position, _minActivationDistance);
	}
}
