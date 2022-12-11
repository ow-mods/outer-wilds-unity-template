using UnityEngine;

public class RandomPointSoundGroup : MonoBehaviour
{
	[SerializeField]
	private AudioType _pointAudioType;
	[SerializeField]
	private Vector2 _delayRange;
	[SerializeField]
	private float _minPlayDistance;
	[Space]
	[SerializeField]
	private AudioVolume _audioVolume;
	[SerializeField]
	private OWAudioSource[] _pointSources;

	[ContextMenu("Populate Point Sources", false)]
	private void PopulatePointSources()
	{
		_pointSources = GetComponentsInChildren<OWAudioSource>();
	}
}
