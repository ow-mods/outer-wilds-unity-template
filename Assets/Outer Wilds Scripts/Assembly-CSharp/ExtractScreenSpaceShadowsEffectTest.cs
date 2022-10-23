using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(Camera))]
public class ExtractScreenSpaceShadowsEffectTest : MonoBehaviour
{
	public RenderTexture rTex;
	public BuiltinRenderTextureType rType;
}
