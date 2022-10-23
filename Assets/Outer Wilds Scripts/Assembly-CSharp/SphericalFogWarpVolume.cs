using UnityEngine;

public class SphericalFogWarpVolume : FogWarpVolume
{
	[Space]
	[SerializeField]
	protected float _warpRadius;
	[SerializeField]
	protected float _exitRadius;

	public void DrawExitMarkers()
	{
		SphericalFogWarpExit[] componentsInChildren = GetComponentsInChildren<SphericalFogWarpExit>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Gizmos.color = Color.red;
			Gizmos.DrawSphere(base.transform.position + componentsInChildren[i].transform.up * _exitRadius, 7.5f);
		}
	}

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = new ColorHSV(300f, 0.8f, 0.8f).ToColorRGB();
			Gizmos.DrawWireSphere(base.transform.position, _warpRadius);
			Gizmos.color = new ColorHSV(300f, 0.4f, 0.4f).ToColorRGB();
			Gizmos.DrawWireSphere(base.transform.position, _exitRadius);
			DrawExitMarkers();
		}
	}
}
