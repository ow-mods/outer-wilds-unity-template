using UnityEngine;

public class EclipseCodeController4 : AbstractGhostDoorInterface
{
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private GearInterfaceEffects _gearInterfaceHorizontal;
	[SerializeField]
	private GearInterfaceEffects _gearInterfaceVertical;
	[SerializeField]
	private RotaryDial[] _dials;
	[SerializeField]
	private Transform _lockOnTransform;
	[SerializeField]
	private Transform[] _selectors;
	[Space]
	[SerializeField]
	private int[] _code;
	[SerializeField]
	private string[] _factIDs = new string[0];
	[Space]
	[SerializeField]
	private OWAudioSource _oneShotAudio;
}
