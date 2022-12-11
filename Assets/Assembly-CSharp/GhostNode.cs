using UnityEngine;
using System.Collections.Generic;

public class GhostNode
{
	public enum NodeLayer
	{
		Red = 1,
		Yellow = 2,
		Blue = 4,
		Orange = 8,
		Green = 16,
		Purple = 32,
	}

	public class PathData
	{
		public bool isStartOfPath;
		public bool isEndOfPath;
		public int index;
	}

	public class PatrolData
	{
	}

	public class SearchData
	{
		public NodeLayer searchLayer;
		public float searchAngle;
		public float lastSearchTime;
	}

	public string name;
	public int index = -1;
	public Vector3 localPosition;
	public Vector3 localForward;
	public List<GhostNode> neighbors;
	public List<GhostEdge> neighborEdges;
	public List<int> visibleNodes;
	public float lastClearTime;
	public PathData pathData;
	public PatrolData patrolData;
	public SearchData searchData;

	public GhostNode(int index, GhostNodeMarker marker)
	{
		name = marker.name;
		this.index = index;
		localPosition = marker.transform.localPosition;
		localForward = marker.transform.parent.InverseTransformDirection(marker.transform.forward);
		neighbors = new List<GhostNode>();
		neighborEdges = new List<GhostEdge>();
		visibleNodes = new List<int>(marker.visibleNodes.Length);
		foreach (var visibleNode in marker.visibleNodes)
		{
			visibleNodes.Add(visibleNode.nodeIndex);
		}
		lastClearTime = -100f;
		if (marker.isPathNode)
		{
			pathData = new PathData();
			pathData.isStartOfPath = marker.pathStart;
			pathData.isEndOfPath = marker.pathEnd;
		}
		if (marker.isPatrolNode)
		{
			patrolData = new PatrolData();
		}
		if (marker.isSearchNode)
		{
			searchData = new SearchData();
			searchData.searchLayer = marker.searchLayer;
			searchData.searchAngle = marker.searchAngle;
			searchData.lastSearchTime = -100f;
		}
	}
}
