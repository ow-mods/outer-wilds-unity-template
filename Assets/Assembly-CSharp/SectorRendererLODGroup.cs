using UnityEngine;

[AddComponentMenu("Sectors/Sector Renderer LOD Group", 400)]
public class SectorRendererLODGroup : CullGroup
{
	[SerializeField]
	private Sector _LODsector;
	[SerializeField]
	private Sector _sectorWhereActive;
}
