using UnityEngine;

public class PlayerAttachPoint : MonoBehaviour
{
	[SerializeField]
	private bool _lockPlayerTurning = true;
	[SerializeField]
	private bool _matchRotation = true;
	[SerializeField]
	private bool _centerCamera = true;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.yellow;
		OWGizmos.DrawWireCapsule(base.transform.position, base.transform.rotation, 1f, 0.5f);
	}
}
