using UnityEngine;
using System.Collections.Generic;

public class GhostNodeMap : MonoBehaviour
{
	public struct NodeSearchData
	{
		public GhostNode node;
		public float score;
		public bool searched;
	}

	[SerializeField]
	private List<GhostMarkerEdge> _markerEdges;
	[SerializeField]
	private Shape _mapBounds;

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		for (int i = 0; i < _markerEdges.Count; i++)
		{
			Gizmos.DrawLine(_markerEdges[i].markerOne.transform.position, _markerEdges[i].markerTwo.transform.position);
		}
	}
}
