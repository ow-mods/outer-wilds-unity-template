using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
	[SerializeField]
	private GameObject _projectilePrefab;
	[SerializeField]
	private float _minSpeed = 50f;
	[SerializeField]
	private float _maxSpeed = 100f;
	[SerializeField]
	private float _angularSpeed;
	[SerializeField]
	private float _launcherRadius;
	[SerializeField]
	private float _launchConeAngle;
	[SerializeField]
	private bool _useLaunchTimer;
	[SerializeField]
	private float _minLaunchDelay = 1f;
	[SerializeField]
	private float _maxLaunchDelay = 5f;

	private void OnDrawGizmosSelected()
	{
		if (OWGizmos.IsDirectlySelected(base.gameObject))
		{
			Gizmos.color = Color.red;
			Gizmos.DrawRay(base.transform.position, base.transform.forward * (_minSpeed + _maxSpeed) * 0.5f);
			Gizmos.DrawWireSphere(base.transform.position, _launcherRadius);
			Gizmos.color = Color.white;
			Gizmos.DrawRay(base.transform.position, Quaternion.AngleAxis(_launchConeAngle, base.transform.right) * base.transform.forward * _launcherRadius);
			Gizmos.DrawRay(base.transform.position, Quaternion.AngleAxis(_launchConeAngle, -base.transform.right) * base.transform.forward * _launcherRadius);
			Gizmos.DrawRay(base.transform.position, Quaternion.AngleAxis(_launchConeAngle, base.transform.up) * base.transform.forward * _launcherRadius);
			Gizmos.DrawRay(base.transform.position, Quaternion.AngleAxis(_launchConeAngle, -base.transform.up) * base.transform.forward * _launcherRadius);
		}
	}
}
