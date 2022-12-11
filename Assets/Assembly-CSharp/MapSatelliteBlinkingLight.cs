using UnityEngine;

public class MapSatelliteBlinkingLight : MonoBehaviour
{
	[Tooltip("Particle system shown in 1st person")]
	[SerializeField]
	private ParticleSystem _firstPersonParticleSystem;
	[Tooltip("Particle system shown in map")]
	[SerializeField]
	private ParticleSystem _mapParticleSystem;

}
