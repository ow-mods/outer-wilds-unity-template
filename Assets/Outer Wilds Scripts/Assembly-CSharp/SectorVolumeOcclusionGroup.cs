using UnityEngine;

[AddComponentMenu("Sectors/Sector Volume Occlusion Group", 200)]
public class SectorVolumeOcclusionGroup : VolumeOcclusionGroup
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private float _fadeLength;
}
