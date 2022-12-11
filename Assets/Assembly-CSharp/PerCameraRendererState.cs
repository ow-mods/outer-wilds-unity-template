using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(Renderer))]
public class PerCameraRendererState : MonoBehaviour
{
	[SerializeField]
	private OWCamera _owCamera;
	[SerializeField]
	private bool _enabled = true;
	[SerializeField]
	private ShadowCastingMode _shadowCastingMode = ShadowCastingMode.On;
}
