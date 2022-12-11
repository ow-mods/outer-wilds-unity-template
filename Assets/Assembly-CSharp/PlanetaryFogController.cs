using UnityEngine;

public class PlanetaryFogController : MonoBehaviour
{
	[SerializeField]
	private Texture3D _fogLookupTexture;
	[SerializeField]
	private float _fogRadius = 300f;
	[SerializeField]
	private float _fogDensity = 1f;
	[SerializeField]
	[Range(0f, 2f)]
	private float _fogExponent = 1f;
	[SerializeField]
	private Texture2D _fogColorRampTexture;
	[SerializeField]
	private float _fogColorRampIntensity = 1f;
	[SerializeField]
	private Color _fogTint = Color.white;
	[SerializeField]
	private float _skyboxFactor = 1f;
	[Header("Fog Impostor (Optional)")]
	[SerializeField]
	private Renderer _fogImpostor;
	[SerializeField]
	private float _lodFadeDistance = 100f;
	[Header("DLC")]
	[SerializeField]
	private bool _isRingworldFog;
	[SerializeField]
	private float _ringworldPlaneDist1 = 160.11f;
	[SerializeField]
	private float _ringworldPlaneDist2 = 161.67f;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = Color.green;
			Gizmos.DrawWireSphere(base.transform.position, _fogRadius);
			Gizmos.color = Color.red;
			Gizmos.DrawWireSphere(base.transform.position, _fogRadius + _lodFadeDistance);
		}
	}
}
