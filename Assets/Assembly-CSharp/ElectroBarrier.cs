using UnityEngine;

public class ElectroBarrier : SectoredMonoBehaviour
{
	[Space]
	[SerializeField]
	private float _barrierRadius = 100f;
	[SerializeField]
	private float _auraDist = 50f;
	[SerializeField]
	private float _staticDist = 10f;
	[Space]
	[SerializeField]
	private GameObject _auraPrefab;
	[SerializeField]
	private GameObject _staticPrefab;
}
