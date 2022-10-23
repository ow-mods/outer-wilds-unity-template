using System;

[Serializable]
public class GhostMarkerEdge
{
	public GhostNodeMarker markerOne;
	public GhostNodeMarker markerTwo;

	public GhostMarkerEdge(GhostNodeMarker markerOne, GhostNodeMarker markerTwo)
	{
		this.markerOne = markerOne;
		this.markerTwo = markerTwo;
	}
}
