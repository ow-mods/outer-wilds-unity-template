using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
	[SerializeField]
	private SpawnLocation _spawnLocation;
	[SerializeField]
	private bool _isShipSpawn;
	[SerializeField]
	private OWTriggerVolume[] _triggerVolumes;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.green;
		if (!_isShipSpawn)
		{
			Gizmos.DrawWireSphere(base.transform.position - base.transform.up * 0.5f, 0.5f);
			Gizmos.DrawWireSphere(base.transform.position + base.transform.up * 0.5f, 0.5f);
		}
		else
		{
			Gizmos.DrawWireSphere(base.transform.position, 5f);
		}
	}
}
