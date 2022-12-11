using UnityEngine;

public class SunLightController : MonoBehaviour
{
	public interface ISunOverrider
	{
	}

	public struct SunOverrideSettings
	{
		public Color sunColor;
		public float sunIntensity;
		public float sunShadowStrength;
		public float ambientIntensity;
	}

	[SerializeField]
	private Light _sunLight;
	[SerializeField]
	private Light _ambientLight;
}
