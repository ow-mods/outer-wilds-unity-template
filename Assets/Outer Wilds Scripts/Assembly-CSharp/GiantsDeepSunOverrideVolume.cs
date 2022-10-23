using UnityEngine;

public class GiantsDeepSunOverrideVolume : SectoredMonoBehaviour
{
	[SerializeField]
	private int _priority = -1;
	[SerializeField]
	private float _cloudsOuterRadius = 950f;
	[SerializeField]
	private float _cloudsInnerRadius = 850f;
	[SerializeField]
	private float _innerIntensity = 0.75f;
	[SerializeField]
	private float _waterOuterRadius = 500f;
	[SerializeField]
	private float _waterInnerRadius = 400f;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = new Color(0.5f, 1f, 0.5f);
			Gizmos.DrawWireSphere(base.transform.position, _cloudsOuterRadius);
			Gizmos.color = new Color(0f, 1f, 0f);
			Gizmos.DrawWireSphere(base.transform.position, _cloudsInnerRadius);
			Gizmos.color = new Color(0.5f, 0.5f, 1f);
			Gizmos.DrawWireSphere(base.transform.position, _waterOuterRadius);
			Gizmos.color = new Color(0f, 0f, 1f);
			Gizmos.DrawWireSphere(base.transform.position, _waterInnerRadius);
		}
	}
}
