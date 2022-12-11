using UnityEngine;

public class GhostEdge
{
	public int index = -1;
	public GhostNode nodeOne;
	public GhostNode nodeTwo;
	public float length;

	public GhostEdge(int index, GhostNode nodeOne, GhostNode nodeTwo)
	{
		this.index = index;
		this.nodeOne = nodeOne;
		this.nodeTwo = nodeTwo;
		length = Vector3.Distance(nodeOne.localPosition, nodeTwo.localPosition);
	}
}