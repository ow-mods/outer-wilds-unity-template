using UnityEngine;

public class SupernovaPlanetEffectController : MonoBehaviour
{
	[SerializeField]
	private Light _ambientLight;
	[SerializeField]
	private LODGroup _atmosphere;
	[SerializeField]
	private PlanetaryFogController _fog;
	[Space]
	[SerializeField]
	private MeshRenderer _shockLayer;
	[ColorUsage(true, true)]
	[SerializeField]
	private Color _shockLayerColor = Color.white;
	[SerializeField]
	private float _shockLayerStartRadius = 10000f;
	[SerializeField]
	private float _shockLayerFullRadius = 20000f;
	[SerializeField]
	private float _shockLayerTrailLength = 100f;
	[SerializeField]
	private float _shockLayerTrailFlare = 100f;
}
