using UnityEngine;

[RequireComponent(typeof(Light))]
public class NightLight : SectoredMonoBehaviour
{
	[SerializeField]
	private OWRenderer[] _emissiveRenderers;
	[Space(10f)]
	[SerializeField]
	private float _dayLightIntensityMultiplier = 0.5f;
	[SerializeField]
	private float _dayEmissionIntensityMultiplier = 0.5f;
	[Space(10f)]
	[SerializeField]
	private float _fadeLength = 5f;
}
