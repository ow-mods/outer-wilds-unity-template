using UnityEngine;

public class VoidShadowEffectController : MonoBehaviour
{
	[SerializeField]
	private OWRenderer[] _objectRenderers = new OWRenderer[0];
	[SerializeField]
	private OWRenderer[] _objectVoidShadowRenderers = new OWRenderer[0];
	[SerializeField]
	private AnimationCurve _objectDissolveCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
	[SerializeField]
	private Transform _voidCracksParent;
	[SerializeField]
	private Vector3 _voidCracksParentOffset = Vector3.zero;

	private void OnDrawGizmos()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = Color.red;
			Gizmos.matrix = ((_voidCracksParent != null) ? _voidCracksParent.localToWorldMatrix : base.transform.localToWorldMatrix);
			Gizmos.DrawLine(_voidCracksParentOffset + Vector3.down, _voidCracksParentOffset + Vector3.up);
			Gizmos.DrawLine(_voidCracksParentOffset + Vector3.back, _voidCracksParentOffset + Vector3.forward);
			Gizmos.DrawLine(_voidCracksParentOffset + Vector3.left, _voidCracksParentOffset + Vector3.right);
		}
	}
}
