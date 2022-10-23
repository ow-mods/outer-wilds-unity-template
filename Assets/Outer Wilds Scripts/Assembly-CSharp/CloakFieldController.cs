using UnityEngine;

public class CloakFieldController : MonoBehaviour
{
	[SerializeField]
	private OWRenderer _cloakSphereRenderer;
	[SerializeField]
	private Sector _exclusionSector;
	[SerializeField]
	private ReferenceFrameVolume _referenceFrameVolume;
	[Space]
	[SerializeField]
	private SphereShape _cloakSphereShape;
	[SerializeField]
	private OWTriggerVolume _cloakSphereVolume;
	[Space]
	[SerializeField]
	private float _nearCloakRadius = 800f;
	[SerializeField]
	private float _farCloakRadius = 500f;
	[SerializeField]
	private float _innerCloakRadius = 800f;
	[SerializeField]
	private float _cloakScaleDist = 2000f;
	[Space]
	[SerializeField]
	private float _entryFadeOutLength = 1f;
	[SerializeField]
	private float _entryFadeInLength = 1f;
	[SerializeField]
	private float _exitFadeOutLength = 1f;
	[SerializeField]
	private float _exitFadeInLength = 1f;
	[Space]
	[SerializeField]
	private OWRenderer[] _ringworldFadeRenderers = new OWRenderer[0];
	[Space]
	[SerializeField]
	private OWAudioSource _musicAudioSource;
}
