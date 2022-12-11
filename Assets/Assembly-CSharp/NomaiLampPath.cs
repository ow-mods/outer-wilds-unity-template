using UnityEngine;

public class NomaiLampPath : MonoBehaviour
{
	[SerializeField]
	private NomaiLamp[] _lamps = new NomaiLamp[0];
	[SerializeField]
	private float _triggerDistance = 6f;

	private void OnDrawGizmosSelected()
	{
		foreach (var lamp in _lamps)
		{
			if (lamp == null) continue;
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireSphere(lamp.transform.position + lamp.transform.up, _triggerDistance);
		}
	}
}
