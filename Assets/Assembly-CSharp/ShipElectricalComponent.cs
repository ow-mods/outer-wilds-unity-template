using UnityEngine;

public class ShipElectricalComponent : ShipComponent
{
	[Space(10f)]
	[SerializeField]
	protected ElectricalSystem _electricalSystem;
	[SerializeField]
	protected ShipLogController _shipLogController;
	[SerializeField]
	protected LandingCamera _landingCamera;
	[SerializeField]
	protected float _disruptionImpactSpeed = 30f;
	[SerializeField]
	protected float _disruptionLength = 1f;
	[SerializeField]
	private OWAudioSource _audioSource;
}
