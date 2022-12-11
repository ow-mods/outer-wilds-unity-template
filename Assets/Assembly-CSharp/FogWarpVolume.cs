using UnityEngine;

public class FogWarpVolume : MonoBehaviour
{
	[SerializeField]
	private Sector _sector;
	[Space]
	[SerializeField]
	[ColorUsage(false, true)]
	private Color _fogColor = Color.gray;
}
