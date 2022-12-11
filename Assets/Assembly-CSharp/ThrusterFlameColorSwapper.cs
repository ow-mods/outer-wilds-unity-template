using UnityEngine;

public class ThrusterFlameColorSwapper : MonoBehaviour
{
	[SerializeField]
	private Renderer[] _thrusterRenderers = new Renderer[0];
	[SerializeField]
	private Texture2D _thrusterFlameSwapTex;
	[SerializeField]
	private Light[] _thrusterLights = new Light[0];
	[SerializeField]
	private Color _thrusterLightsSwapColor = Color.white;
}