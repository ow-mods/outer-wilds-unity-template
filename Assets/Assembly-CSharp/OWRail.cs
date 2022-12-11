using UnityEngine;

public class OWRail : MonoBehaviour
{
	[SerializeField]
	private Vector3[] _railPoints;
	[SerializeField]
	private bool _generateFromChildren;

	private void OnDrawGizmosSelected()
	{
		if (_railPoints == null) return;
		
		Gizmos.color = Color.yellow;
		for (int i = 0; i < _railPoints.Length; i++)
		{
			Gizmos.DrawSphere(base.transform.TransformPoint(_railPoints[i]), 0.05f);
			if (i > 0)
			{
				Gizmos.DrawLine(base.transform.TransformPoint(_railPoints[i - 1]), base.transform.TransformPoint(_railPoints[i]));
			}
		}
	}
}
