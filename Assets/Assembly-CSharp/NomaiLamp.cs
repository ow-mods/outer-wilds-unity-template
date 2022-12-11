using UnityEngine;

public class NomaiLamp : MonoBehaviour
{
	[SerializeField]
	private bool _startOn = true;
	[SerializeField]
	private Renderer[] _emissiveRenderers;
	[SerializeField]
	private int _materialIndex;
}
