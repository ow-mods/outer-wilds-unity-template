using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightmapController : MonoBehaviour
{
	public enum LightmapChannel
	{
		Red = 0,
		Green = 1,
		Blue = 2,
		Alpha = 3,
	}

	[SerializeField]
	private Material[] _materials = new Material[0];
	[SerializeField]
	private LightmapChannel _channel;
}
