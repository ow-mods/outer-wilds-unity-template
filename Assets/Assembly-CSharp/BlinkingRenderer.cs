using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class BlinkingRenderer : MonoBehaviour
{
	[SerializeField]
	private float _onSeconds = 1f;
	[SerializeField]
	private float _offSeconds = 1f;
}
