using UnityEngine;

public class VisibilityObject : SectoredMonoBehaviour
{
	[SerializeField]
	private bool _checkIllumination;
	[SerializeField]
	private float _illuminationRadius;
	[SerializeField]
	private Vector3 _localIlluminationOffset = Vector3.zero;

	private void OnDrawGizmosSelected()
	{
		if (_checkIllumination)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireSphere(base.transform.TransformPoint(_localIlluminationOffset), _illuminationRadius);
		}
	}
}
