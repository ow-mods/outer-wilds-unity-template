using UnityEngine;

public class TrailDistanceCalculator : MonoBehaviour
{
	[SerializeField]
	private float _distance;
	[SerializeField]
	private GameObject _waypointRoot;
	[SerializeField]
	private bool _update;

	private Transform[] _waypoints;

	private void OnValidate()
	{
		if (_update)
		{
			_update = false;
		}
		_distance = 0f;
		if (_waypointRoot != null)
		{
			_waypoints = _waypointRoot.GetComponentsInChildren<Transform>();
		}
		else
		{
			_waypoints = new Transform[0];	
		}
		for (int num = _waypoints.Length - 1; num > 0; num--)
		{
			_distance += Vector3.Distance(_waypoints[num].position, _waypoints[num - 1].position);
		}
	}

	private void OnDrawGizmosSelected()
	{
		if (_waypointRoot != null)
		{
			_waypoints = _waypointRoot.GetComponentsInChildren<Transform>();
		}
		else
		{
			_waypoints = new Transform[0];	
		}
		for (int num = _waypoints.Length - 1; num > 0; num--)
		{
			Gizmos.color = Color.red;
			Gizmos.DrawLine(_waypoints[num].position, _waypoints[num - 1].position);
		}
	}
}
