using UnityEngine;

[ImageEffectAllowedInSceneView]
[RequireComponent(typeof(Camera))]
public class PlanetaryFogImageEffect : MonoBehaviour
{
	public Shader fogShader;
}
