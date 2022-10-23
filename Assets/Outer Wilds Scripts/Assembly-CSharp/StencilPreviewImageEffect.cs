using UnityEngine;

[ImageEffectAllowedInSceneView]
[RequireComponent(typeof(Camera))]
public class StencilPreviewImageEffect : MonoBehaviour
{
	private enum Flag
	{
		Underwater = 1,
		ShipInterior = 2,
	}

	[SerializeField]
	private Flag _flag;
}
