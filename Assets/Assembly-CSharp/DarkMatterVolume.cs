using UnityEngine;

public class DarkMatterVolume : HazardVolume
{
	[Space]
	[SerializeField]
	protected ParticleSystem _particleTrail;
	[SerializeField]
	protected float _rateOverTime = 5f;
	[SerializeField]
	protected float _rateOverDistance = 3f;
}
