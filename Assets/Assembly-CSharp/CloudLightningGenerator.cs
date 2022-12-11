using UnityEngine;

public class CloudLightningGenerator : MonoBehaviour
{
	[SerializeField]
	protected float _altitude = 900f;
	[Space]
	[SerializeField]
	private Gradient _lightColor = new Gradient();
	[SerializeField]
	private Range _lightIntensity = new Range(3f, 5f);
	[SerializeField]
	private Range _lightDuration = new Range(0.5f, 2f);
	[SerializeField]
	private Range _lightRadius = new Range(300f, 800f);
	[SerializeField]
	private CloudLightning.AnimSettings[] _lightRandomAnimSettings = new CloudLightning.AnimSettings[0];
	[SerializeField]
	private LightRenderMode _lightRenderMode = LightRenderMode.ForceVertex;
	[SerializeField]
	private Range _delay = new Range(0f, 10f);
	[SerializeField]
	private Range _branches = new Range(0f, 5f);
	[SerializeField]
	protected Range _branchDistance = new Range(10f, 50f);
	[SerializeField]
	private Range _branchDelay = new Range(0.1f, 0.5f);
	[Space]
	[SerializeField]
	private GameObject _audioPrefab;
	[SerializeField]
	private Sector _audioSector;
}
