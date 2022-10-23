using UnityEngine;

[AddComponentMenu("Sectors/Multi-Sector Cull Group", 200)]
public class MultiSectorCullGroup : SectorCullGroup
{
	[SerializeField]
	private Sector _secondSector;
}
