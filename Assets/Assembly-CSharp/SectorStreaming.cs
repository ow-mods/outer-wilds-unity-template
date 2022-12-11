using UnityEngine;

[AddComponentMenu("Streaming/Sector Streaming", 200)]
public class SectorStreaming : SectoredMonoBehaviour
{
	[SerializeField]
	private StreamingGroup _streamingGroup;
	[SerializeField]
	private float _softLoadRadius = 2000f;

	protected virtual void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = Color.green;
			Gizmos.DrawWireSphere(base.transform.position, _softLoadRadius);
		}
	}
}
