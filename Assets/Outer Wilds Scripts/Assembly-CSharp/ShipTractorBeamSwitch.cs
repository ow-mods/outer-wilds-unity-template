using UnityEngine;

public class ShipTractorBeamSwitch : MonoBehaviour
{
	[SerializeField]
	private FluidVolume _beamFluid;
	[SerializeField]
	private ParticleSystem[] _particleSystems = new ParticleSystem[0];
	[SerializeField]
	private Light[] _lights = new Light[0];
}
