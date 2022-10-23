using UnityEngine;

public class NomaiEnergyCable : MonoBehaviour
{
	[SerializeField]
	private Renderer _cableRenderer;
	[SerializeField]
	private float _scale = 1f;
	[SerializeField]
	private float _offset = 0.6f;
	[SerializeField]
	private bool _startPowered;
}
