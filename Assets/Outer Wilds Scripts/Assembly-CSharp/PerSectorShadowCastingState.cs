using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(Renderer))]
public class PerSectorShadowCastingState : MonoBehaviour
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private ShadowCastingMode _shadowCastingMode = ShadowCastingMode.On;
}
