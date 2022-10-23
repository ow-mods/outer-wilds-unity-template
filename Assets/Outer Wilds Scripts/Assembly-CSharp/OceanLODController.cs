using UnityEngine;

public class OceanLODController : SectoredMonoBehaviour
{
	[SerializeField]
	private Light _ambientLight;
	[SerializeField]
	private Texture2D _ambientLightLookup;
	[Space]
	[SerializeField]
	private int _maxLOD_High = 8;
	[SerializeField]
	private int _LODBias_High;
	[SerializeField]
	private int _maxLOD_Medium = 5;
	[SerializeField]
	private int _LODBias_Medium;
	[SerializeField]
	private int _maxLOD_Low = 3;
	[SerializeField]
	private int _LODBias_Low;
}
