using UnityEngine;

[AddComponentMenu("Audio/Audio Rail", 300)]
public class AudioRail : SectoredMonoBehaviour
{
	[SerializeField]
	private Transform _audioTransform;
	[SerializeField]
	private Transform _railPointsRoot;
	[SerializeField]
	[HideInInspector]
	private bool _prebuilt;
	[SerializeField]
	[HideInInspector]
	private Vector3[] _railPoints;
	[SerializeField]
	[HideInInspector]
	private LineSegmentDistanceTracker[] _lineSegments;

	private void OnDrawGizmosSelected()
	{
		if (_railPointsRoot == null) return;
		Gizmos.color = Color.yellow;
		for (int i = 0; i < _railPointsRoot.childCount; i++)
		{
			Gizmos.DrawWireSphere(_railPointsRoot.GetChild(i).position, 1f);
			if (i > 0)
			{
				Gizmos.DrawLine(_railPointsRoot.GetChild(i - 1).position, _railPointsRoot.GetChild(i).position);
			}
		}
		if (_audioTransform == null) return;
		Gizmos.DrawSphere(_audioTransform.position, 1f);
	}
}
