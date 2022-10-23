using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightLOD : MonoBehaviour
{
	[SerializeField]
	private bool _fadeShadows;
	[SerializeField]
	private float _shadowFadeStart = 50f;
	[SerializeField]
	private float _shadowFadeEnd = 75f;
	[Space]
	[SerializeField]
	private bool _disableOnQualitySetting;
	[SerializeField]
	private ShadowQuality _highestQualitySetting = ShadowQuality.HIGH;

	private void OnDrawGizmosSelected()
	{
		if (_fadeShadows)
		{
			Gizmos.matrix = Matrix4x4.TRS(base.transform.position, base.transform.rotation, Vector3.one);
			Gizmos.color = new Color(0.2f, 0.2f, 1f, 0.5f);
			Gizmos.DrawWireSphere(Vector3.zero, _shadowFadeStart);
			Gizmos.color = new Color(0.2f, 0.2f, 0.5f, 0.5f);
			Gizmos.DrawWireSphere(Vector3.zero, _shadowFadeEnd);
		}
	}
}
