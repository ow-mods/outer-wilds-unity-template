using System;
using System.Xml.Linq;

[Serializable]
public class ShipLogEntry
{
	public enum State
	{
		None,
		Hidden,
		Rumored,
		Explored
	}

	public ShipLogEntry(string astroObjectID, XElement entryNode, string parentID)
	{
	}
}
