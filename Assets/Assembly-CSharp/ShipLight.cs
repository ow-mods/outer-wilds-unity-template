using UnityEngine;

[RequireComponent(typeof(Light))]
public class ShipLight : ElectricalComponent
{
	[SerializeField]
	private Renderer _emissiveRenderer;
	[SerializeField]
	private int _materialIndex;
	[Space(10f)]
	[SerializeField]
	private float _fadeLength = 1f;
}
