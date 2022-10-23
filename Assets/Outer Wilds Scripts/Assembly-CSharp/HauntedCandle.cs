using UnityEngine;
using System.Collections.Generic;

public class HauntedCandle : MonoBehaviour
{
	[SerializeField]
	private bool _startLit = true;
	[SerializeField]
	private GameObject _objectsVisibleInLight;
	[SerializeField]
	private GameObject _lightsRoot;
	[SerializeField]
	private List<NomaiLamp> _lights;
	[Space]
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private OWLightController _candleLightController;
	[SerializeField]
	private ParticleSystem _candleParticles;
	[Space]
	[SerializeField]
	private GameObject _doorsRoot;
	[SerializeField]
	private List<LightCodeDoor> _doorsToClose;
	[Space]
	[SerializeField]
	public HauntedRoom p_room;
}
