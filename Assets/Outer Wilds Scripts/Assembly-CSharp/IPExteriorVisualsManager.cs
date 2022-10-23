using UnityEngine;

public class IPExteriorVisualsManager : SectoredMonoBehaviour
{
	[SerializeField]
	private Renderer[] _exteriorVisualsRenderers = new Renderer[0];
	[SerializeField]
	private Renderer[] _cockpitExteriorVisuals = new Renderer[0];
	[SerializeField]
	private Renderer[] _observationDeckHiddenVisuals = new Renderer[0];
	[SerializeField]
	private Sector _cockpitSector;
	[SerializeField]
	private Sector _observationDeckSector;
}
