using UnityEngine;

[RequireComponent(typeof(Light))]
public class SwitchLightOptimization : MonoBehaviour
{
	public bool skip;
	[Header("Lighting Settings")]
	public bool disableShadows = true;
}
