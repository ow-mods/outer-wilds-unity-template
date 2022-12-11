using UnityEngine;

public class SphericalFogWarpExit : MonoBehaviour
{
	[SerializeField]
	private float _upperMinExitSpeed;
	[SerializeField]
	private float _lowerMinExitSpeed;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			SphericalFogWarpVolume componentInParent = GetComponentInParent<SphericalFogWarpVolume>();
			if (componentInParent != null)
			{
				componentInParent.DrawExitMarkers();
			}
		}
	}
}
