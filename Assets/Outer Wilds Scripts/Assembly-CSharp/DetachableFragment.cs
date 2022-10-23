using UnityEngine;

public class DetachableFragment : MonoBehaviour
{
	public enum ForceMask
	{
		Everything = 0,
		SunOnly = 1,
		ParentOnly = 2,
	}

	[SerializeField]
	private GameObject _destructibleRoot;
	[SerializeField]
	private float _destructibleDelay = 2f;
	[SerializeField]
	private Vector3 _localCenterOfMass = Vector3.zero;
	[SerializeField]
	private Transform _centerOfMassOverride;
	[SerializeField]
	private float _mass = 100f;
	[SerializeField]
	private float _drag = 10f;
	[SerializeField]
	private ForceMask _forceDetection = ForceMask.ParentOnly;
	[SerializeField]
	[HideInInspector]
	private Vector3 _fragmentBoundSize = Vector3.zero;
	[SerializeField]
	private bool _makeKinematic = true;
	[SerializeField]
	private bool _addShapeToDetector;
	[SerializeField]
	private float _detectorRadius = 0.5f;
	[SerializeField]
	private bool _drawBounds;
	[SerializeField]
	private bool _muteAudio;
	[SerializeField]
	private AudioType _overrideDefaultAudio;
	[SerializeField]
	private OWAudioSource _audioSource;

	public Vector3 GetWorldCenterOfMass()
	{
		return base.transform.TransformPoint(_localCenterOfMass);
	}

	private void OnDrawGizmosSelected()
	{
		if (_drawBounds)
		{
			Gizmos.color = Color.red;
			Vector3 vector = base.transform.TransformPoint(_localCenterOfMass);
			Gizmos.DrawLine(vector + base.transform.up * 10f, vector - base.transform.up * 10f);
			Gizmos.DrawLine(vector + base.transform.right * 10f, vector - base.transform.right * 10f);
			Gizmos.DrawLine(vector + base.transform.forward * 10f, vector - base.transform.forward * 10f);
			Gizmos.DrawWireCube(vector, _fragmentBoundSize);
			if (_centerOfMassOverride != null)
			{
				Gizmos.DrawSphere(_centerOfMassOverride.position, 5f);
			}
		}
	}
}
