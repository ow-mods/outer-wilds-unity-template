using UnityEngine;

[AddComponentMenu("Sectors/Sector Cull Group", 200)]
public class SectorCullGroup : CullGroup
{
	[SerializeField]
	protected Sector _sector;
	[SerializeField]
	protected SectorProxy _controllingProxy;
}
