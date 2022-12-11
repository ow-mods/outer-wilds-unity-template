using UnityEngine;

public class HazardDetector : Detector
{
	[SerializeField]
	private GameObject _darkMatterEntryEffect;
	[SerializeField]
	private float _darkMatterMinEntrySpeed = 1f;
	[Space]
	[SerializeField]
	private ElectricityEffect[] _electricityEffects = new ElectricityEffect[0];
}
