using UnityEngine;

public class CullDistanceTracker : MonoBehaviour
{
	[SerializeField]
	private float[] _levelDistances = new float[0];

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			foreach (var levelDistance in _levelDistances)
			{
				Gizmos.color = Color.white;
				Gizmos.DrawWireSphere(base.transform.position, levelDistance);
			}
		}
	}
}
