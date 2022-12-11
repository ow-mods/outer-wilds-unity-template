using UnityEngine;

public class SwitchLightCastShadowSceneOptimization : MonoBehaviour
{
	public bool skip;
	[Header("Explicit Light Components")]
	public Light[] sceneLightComponents = new Light[0];
	public Light[] prefabLightComponents = new Light[0];
	[Header("Switch Light Component Override Settings")]
	public bool operateOnPrefabLights;
	public bool disableShadows = true;
}
