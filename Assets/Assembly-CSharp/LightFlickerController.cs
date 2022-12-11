using UnityEngine;

public class LightFlickerController : MonoBehaviour
{
	[SerializeField]
	private Renderer _bubbleRenderer;
	[Space]
	[SerializeField]
	private OWLight2[] _lights;
	[SerializeField]
	private GameObject _lightsRoot;
	[Space]
	[SerializeField]
	private OWEmissiveRenderer[] _renderers;
	[SerializeField]
	private GameObject _renderersRoot;
}
