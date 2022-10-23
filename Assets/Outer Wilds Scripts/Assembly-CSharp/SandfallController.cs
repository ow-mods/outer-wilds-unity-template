using System;
using UnityEngine;

public class SandfallController : SectoredMonoBehaviour
{
	[Serializable]
	private struct SandfallParticleSystem
	{
		public ParticleSystem particle;
		public float lifetimeOffset;
	}

	[SerializeField]
	private float _height = 20f;
	[SerializeField]
	private SandfallParticleSystem[] _particles;
	[SerializeField]
	private Transform _sandPile;
	[SerializeField]
	private OWAudioSource _audioSource;
}
