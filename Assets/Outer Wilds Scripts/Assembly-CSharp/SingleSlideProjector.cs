using UnityEngine;

public class SingleSlideProjector : MonoBehaviour
{
	[SerializeField]
	private LightSensor _lightSensor;
	[Space]
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private OWRendererFadeController _lightShaftController;
	[SerializeField]
	private OWLightController _bounceLightController;
	[Space]
	[SerializeField]
	private OWCollider _shipLogTriggerCollider;
}
