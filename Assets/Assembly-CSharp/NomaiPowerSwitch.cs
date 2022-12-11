using UnityEngine;

public class NomaiPowerSwitch : MonoBehaviour
{
	[SerializeField]
	private NomaiInterfaceSlot _powerSourceSlot;
	[Space]
	[SerializeField]
	private bool _startOn;
	[SerializeField]
	private NomaiInterfaceSlot _slot;
	[SerializeField]
	private float _fadeDuration = 3f;
	[SerializeField]
	private NomaiLamp[] _onLamps;
	[SerializeField]
	private OWLightController[] _onLightControllers;
	[SerializeField]
	private TractorBeamController[] _onTractorBeams;
	[SerializeField]
	private NomaiLamp[] _offLamps;
	[SerializeField]
	private TractorBeamController[] _offTractorBeams;
	[SerializeField]
	private NomaiEnergyCable _energyCable;
	[Space]
	[SerializeField]
	private OWAudioSource _audioSource;
	[SerializeField]
	private AudioType _onClip;
	[SerializeField]
	private AudioType _offClip;
}
