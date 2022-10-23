using UnityEngine;

public class SceneLoader : MonoBehaviour
{
	[SerializeField]
	private Transform _solarSystemRoot;
	[SerializeField]
	private GameObject _sun;
	[Header("Load Scenes:")]
	[SerializeField]
	private bool _hourglassTwins = true;
	[SerializeField]
	private bool _timberHearth = true;
	[SerializeField]
	private bool _brittleHollow = true;
	[SerializeField]
	private bool _giantsDeep = true;
	[SerializeField]
	private bool _darkBramble = true;
	[SerializeField]
	private bool _comet = true;
	[SerializeField]
	private bool _quantumMoon = true;
	[SerializeField]
	private bool _whiteHole = true;
	[SerializeField]
	private bool _invisiblePlanet;
	[Header("Load Proxy Scenes:")]
	[SerializeField]
	private bool _proxyHourglassTwins = true;
	[SerializeField]
	private bool _proxyTimberHearth = true;
	[SerializeField]
	private bool _proxyBrittleHollow = true;
	[SerializeField]
	private bool _proxyGiantsDeep = true;
	[SerializeField]
	private bool _proxyDarkBramble = true;
	[SerializeField]
	private bool _proxyComet = true;
	[SerializeField]
	private bool _proxyQuantumMoon = true;
	[SerializeField]
	private bool _proxyWhiteHole = true;
	[SerializeField]
	private bool _proxyInvisiblePlanet;
}
