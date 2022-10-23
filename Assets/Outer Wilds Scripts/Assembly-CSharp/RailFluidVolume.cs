using UnityEngine;

public class RailFluidVolume : FluidVolume
{
	[Space]
	[SerializeField]
	private float _flowSpeed;
	[SerializeField]
	private float _inwardSpeed;
	[SerializeField]
	private float _inwardFalloffRadius;
	[SerializeField]
	private bool _horizontalInwardVelocityOnly;
	[SerializeField]
	private float _verticalSpeed;
	[SerializeField]
	private Transform _railPointsRoot;
	[SerializeField]
	private bool _preventPlayerGrounded;
	[SerializeField]
	[HideInInspector]
	private bool _prebuilt;
	[SerializeField]
	[HideInInspector]
	private Vector3[] _railPoints;

	private void OnDrawGizmosSelected()
	{
		if (_railPointsRoot == null) return;
		
		Gizmos.color = Color.yellow;
		for (int i = 0; i < _railPointsRoot.childCount; i++)
		{
			Gizmos.DrawWireSphere(_railPointsRoot.GetChild(i).position, 1f);
			if (i > 0)
			{
				Gizmos.DrawLine(_railPointsRoot.GetChild(i - 1).position, _railPointsRoot.GetChild(i).position);
			}
		}
	}
}
