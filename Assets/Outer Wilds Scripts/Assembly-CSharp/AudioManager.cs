using UnityEngine;

[AddComponentMenu("Audio/Audio Manager", 200)]
public class AudioManager : MonoBehaviour
{
	[SerializeField]
	private AudioLibrary _libraryAsset;
	[SerializeField]
	private bool _debugOn;
}
