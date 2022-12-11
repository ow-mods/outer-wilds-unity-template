using UnityEngine;

public class SandLevelController : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve _scaleCurve;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject) && _scaleCurve != null)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireSphere(base.transform.position, _scaleCurve.Evaluate(22f) * 0.5f);
			OWGizmos.DrawBillboardedWireCircle(base.transform.position, _scaleCurve.Evaluate(22f) * 0.5f);
			Gizmos.DrawWireSphere(base.transform.position, _scaleCurve.Evaluate(0f) * 0.5f);
			OWGizmos.DrawBillboardedWireCircle(base.transform.position, _scaleCurve.Evaluate(0f) * 0.5f);
		}
	}
}
