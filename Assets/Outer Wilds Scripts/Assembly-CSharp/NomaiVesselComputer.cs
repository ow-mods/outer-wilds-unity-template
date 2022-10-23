using UnityEngine;

[RequireComponent(typeof(Collider))]
public class NomaiVesselComputer : NomaiText
{
	[SerializeField]
	private bool _startActivated;
	[Space]
	[SerializeField]
	private Transform _pillarObject;
	[Space]
	[SerializeField]
	private float _pillarStowedHeight;
	[SerializeField]
	private float _pillarExtendedHeight = 2.575525f;
	[SerializeField]
	private float _pillarMoveTime = 1f;
	[Space]
	[SerializeField]
	private OWLight2 _topLight;
	[SerializeField]
	private OWEmissiveRenderer _topLightRenderer;
	[SerializeField]
	private float _lightFadeTime = 1f;
	[Space]
	[SerializeField]
	private NomaiVesselComputerRing[] _computerRings = new NomaiVesselComputerRing[0];
	[SerializeField]
	private float _ringDelay = 1f;
	[Space]
	[SerializeField]
	private OWAudioSource _audioSource;
}
