using UnityEngine;

public class PlanetaryVectionController : MonoBehaviour
{
	private enum FollowTarget
	{
		Player = 0,
		Probe = 1,
	}

	[SerializeField]
	private FollowTarget _followTarget;
	[SerializeField]
	private AnimationCurve _densityByHeight = new AnimationCurve(new Keyframe(100f, 10f), new Keyframe(150f, 0f));
	[SerializeField]
	private Sector _activeInSector;
	[SerializeField]
	private Sector[] _exclusionSectors = new Sector[0];
}
