using UnityEngine;

[AddComponentMenu("Sectors/Sector Lights LOD Group", 400)]
public class SectorLightsLODGroup : LightsCullGroup
{
	[SerializeField]
	private Sector _LODsector;
	[SerializeField]
	private Sector _sectorWhereActive;
	[SerializeField]
	private float _fadeLength = 1f;
}
