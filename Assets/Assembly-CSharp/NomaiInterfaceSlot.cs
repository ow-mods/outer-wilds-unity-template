using UnityEngine;

public class NomaiInterfaceSlot : MonoBehaviour
{
	[SerializeField]
	private float _radius;
	[SerializeField]
	private float _exitRadius;
	[SerializeField]
	private bool _attractive = true;
	[SerializeField]
	private bool _ignoreDraggedOrbs;
	[SerializeField]
	private bool _muteAudio;

	private void OnDrawGizmos()
	{
		Gizmos.color = new ColorHSV(0f, 0.5f, 1f).ToColorRGB();
		Gizmos.DrawWireSphere(base.transform.position, _radius);
		Gizmos.color = new ColorHSV(0f, 0.5f, 0.5f).ToColorRGB();
		Gizmos.DrawWireSphere(base.transform.position, _exitRadius);
	}
}
