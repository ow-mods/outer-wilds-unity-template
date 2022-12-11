using UnityEngine;

public class NomaiRecorderEffects : SectoredMonoBehaviour
{
	[SerializeField]
	private OWRenderer[] _ringRenderers = new OWRenderer[0];
	[SerializeField]
	private int[] _materialIndexes = new int[0];
	[SerializeField]
	private float[] _scrollSpeeds = new float[0];
	[SerializeField]
	private OWAudioSource _audioSource;
}
