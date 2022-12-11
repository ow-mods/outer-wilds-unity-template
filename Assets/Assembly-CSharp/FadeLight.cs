using UnityEngine;

[RequireComponent(typeof(Light))]
public class FadeLight : MonoBehaviour
{
	[SerializeField]
	private Renderer _emissiveRenderer;
	[SerializeField]
	private int _materialIndex;
}
