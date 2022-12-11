using UnityEngine;

public class SecretSlideSocketDoor : MonoBehaviour
{
	[SerializeField]
	private SlideReelSocket _slideReelSocket;
	[SerializeField]
	private AbstractDoor _secretDoor;
	[SerializeField]
	private AbstractDoor _mainDoor;
	[SerializeField]
	private OWLightController _lightController;
	[Space]
	[SerializeField]
	private float _lightFadeLength = 1f;
	[SerializeField]
	private float _doorOpenDelay = 1f;
}
