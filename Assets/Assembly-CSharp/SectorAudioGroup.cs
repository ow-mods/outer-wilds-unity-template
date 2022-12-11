using UnityEngine;

[AddComponentMenu("Sectors/Sector Audio Group", 200)]
public class SectorAudioGroup : MonoBehaviour
{
	[SerializeField]
	private Sector _sector;
	[SerializeField]
	private float _fadeDuration = 1f;
}
