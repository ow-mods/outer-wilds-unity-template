using UnityEngine;

public class NomaiLampSwitch : MonoBehaviour
{
	[SerializeField]
	private bool _startOn;
	[SerializeField]
	private float _fadeDuration = 3f;
	[SerializeField]
	private GameObject _lampRoot;
	[SerializeField]
	private TractorBeamController[] _tractorBeams = new TractorBeamController[0];
	[SerializeField]
	private NomaiInterfaceSlot[] _onSlots;
	[SerializeField]
	private NomaiInterfaceSlot[] _offSlots;
	[SerializeField]
	private NomaiInterfaceSlot[] _toggleSlots;
}
