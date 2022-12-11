using UnityEngine;

[AddComponentMenu("Sectors/Sector Collision Group", 200)]
public class SectorCollisionGroup : CollisionGroup
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private bool _colliderTimeSlicing = true;
}
