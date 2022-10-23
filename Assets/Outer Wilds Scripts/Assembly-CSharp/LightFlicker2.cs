using UnityEngine;

public class LightFlicker2 : SectoredMonoBehaviour
{
	[SerializeField]
	private OWLight2[] _lights;
	[SerializeField]
	private OWEmissiveRenderer[] _renderers;
	[Space(10f)]
	[SerializeField]
	private float _range = 0.1f;
	[SerializeField]
	private float _rate = 0.2f;
}
