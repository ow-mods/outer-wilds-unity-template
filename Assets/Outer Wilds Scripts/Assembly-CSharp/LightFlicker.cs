using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightFlicker : SectoredMonoBehaviour
{
	[SerializeField]
	private Renderer _emissiveRenderer;
	[SerializeField]
	private int _materialIndex;
	[Space(10f)]
	[SerializeField]
	private float _range = 0.1f;
	[SerializeField]
	private float _rate = 0.2f;
}
