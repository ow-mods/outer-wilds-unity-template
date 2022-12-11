using UnityEngine;

[RequireComponent(typeof(Collider))]
public class RepairVolume : MonoBehaviour
{
	[SerializeField]
	private float _repairDistance = 3f;

	[SerializeField]
	private float _secondsToRepair = 3f;
}
