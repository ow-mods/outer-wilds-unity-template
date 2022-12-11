using UnityEngine;

public class SatelliteNode : SectoredMonoBehaviour
{
	[Space]
	[SerializeField]
	private DamageEffect _damageEffect;
	[SerializeField]
	private ReferenceFrameVolume _rfVolume;
	[Space]
	[SerializeField]
	private Light _lanternLight;
	[SerializeField]
	private Color _lightRepairedColor = new Color(0.25f, 1f, 0.25f);
	[SerializeField]
	private MeshRenderer _lanternEmissiveRenderer;
	[SerializeField]
	private int _lanternMaterialIndex;
	[SerializeField]
	private Material _lanternRepairedMaterial;
	[Space]
	[SerializeField]
	private float _repairTime = 3f;
}
