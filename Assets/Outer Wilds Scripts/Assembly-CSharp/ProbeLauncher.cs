using UnityEngine;

public class ProbeLauncher : PlayerTool
{
	public enum Name
	{
		Default = 0,
		Player = 1,
		Ship = 2,
		Stationary = 3,
	}

	[SerializeField]
	protected Name _name;
	[SerializeField]
	protected Transform _launcherTransform;
	[SerializeField]
	private GameObject _launcherGeometry;
	[SerializeField]
	private GameObject _preLaunchProbeProxy;
	[SerializeField]
	private GameObject _probePrefab;
	[Space]
	[SerializeField]
	private SingularityWarpEffect _probeRetrievalEffect;
	[SerializeField]
	private float _probeRetrievalLength = 0.5f;
	[Space]
	[SerializeField]
	private bool _alwaysVisible;
	[SerializeField]
	private bool _shareActiveProbes;
	[SerializeField]
	private NotificationTarget _notificationFilter = NotificationTarget.None;
	[SerializeField]
	private FluidDetector _fluidDetector;
	[SerializeField]
	private ProbeLauncherUI[] _launcherUIs;
}
