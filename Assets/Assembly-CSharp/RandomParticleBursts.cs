using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class RandomParticleBursts : SectoredMonoBehaviour
{
	[SerializeField]
	private float _minDelay = 1f;
	[SerializeField]
	private float _maxDelay = 3f;
	[SerializeField]
	private bool _looping = true;
}
