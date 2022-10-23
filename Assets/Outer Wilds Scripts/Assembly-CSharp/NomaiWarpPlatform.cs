using UnityEngine;

[RequireComponent(typeof(OWTriggerVolume))]
public class NomaiWarpPlatform : MonoBehaviour
{
	public enum Frequency
	{
		None = 0,
		SunStation = 1,
		TimeLoop = 2,
		HourglassTwin = 3,
		TimberHearth = 4,
		BrittleHollowPolar = 5,
		BrittleHollowForge = 6,
		GiantsDeep = 7,
		Vessel = 8,
	}

	[SerializeField]
	private Frequency _frequency;
	[SerializeField]
	private Transform _platformCenter;
	[Space]
	[SerializeField]
	private Vector3 _localWarpPosition = Vector3.zero;
	[SerializeField]
	private float _warpRadius = 0.5f;
	[SerializeField]
	private bool _ignoreRelativeRotation;
	[Space]
	[SerializeField]
	private SingularityController _blackHole;
	[SerializeField]
	private SingularityController _whiteHole;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = Color.green;
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Gizmos.DrawWireSphere(_localWarpPosition, _warpRadius);
		}
	}
}
