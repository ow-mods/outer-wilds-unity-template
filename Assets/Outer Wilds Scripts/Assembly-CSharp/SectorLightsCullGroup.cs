using UnityEngine;

[AddComponentMenu("Sectors/Sector Lights Cull Group", 200)]
public class SectorLightsCullGroup : LightsCullGroup
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private float _fadeLength = 1f;
}
