using UnityEngine;

[ImageEffectAllowedInSceneView]
[RequireComponent(typeof(OWCamera))]
public class HeightmapAmbientLightRenderer : MonoBehaviour
{
	[SerializeField]
	private Shader _lightShader;
}
