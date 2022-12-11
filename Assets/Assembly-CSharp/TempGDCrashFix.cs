using UnityEngine;

public class TempGDCrashFix : MonoBehaviour
{
	[SerializeField]
	private float _radius = 1000f;
	[SerializeField]
	private int _frameDelay = 5;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = Color.red;
			Gizmos.DrawWireSphere(base.transform.position, _radius);
		}
	}
}
