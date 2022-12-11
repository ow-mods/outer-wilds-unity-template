using UnityEngine;

public class UnderwaterCurrentFadeController : SectoredMonoBehaviour
{
	[SerializeField]
	private float _minAlpha = 0.5f;
	[SerializeField]
	private float _minDistance;
	[SerializeField]
	private float _maxDistance;
	[SerializeField]
	private OWRenderer[] _currentRenderers;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireSphere(base.transform.position, _minDistance);
		Gizmos.DrawWireSphere(base.transform.position, _maxDistance);
	}
}
