using UnityEngine;

public class PlanetoidRuleset : RulesetVolume
{
	[SerializeField]
	private float _daySideConeAngle = 180f;
	[SerializeField]
	private float _horizonRadius;
	[SerializeField]
	private bool _useMinimap = true;
	[Space]
	[SerializeField]
	private bool _useAltimeter = true;
	[SerializeField]
	private float _altitudeFloor = 200f;
	[SerializeField]
	private float _altitudeCeiling = 500f;
	[Space]
	[SerializeField]
	private float _shuttleLandingRadius;
	[Space]
	[SerializeField]
	private SandLevelController _sandLevelController;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = Color.green;
			Gizmos.DrawWireSphere(base.transform.position, _horizonRadius);
			if (_useAltimeter)
			{
				Gizmos.color = Color.blue;
				Gizmos.DrawWireSphere(base.transform.position, _altitudeFloor);
				Gizmos.DrawWireSphere(base.transform.position, _altitudeCeiling);
			}
			Gizmos.color = Color.magenta;
			Gizmos.DrawWireSphere(base.transform.position, _shuttleLandingRadius);
		}
	}
}
