using UnityEngine;
using System.Collections.Generic;

public class FloatingBridgeHovering : MonoBehaviour
{
	[SerializeField]
	private float _hoverHeight;
	[SerializeField]
	private float _risingSpeed = 1.5f;
	[SerializeField]
	private bool _startsHovering;
	[SerializeField]
	private GameObject _detector;
	[SerializeField]
	private List<OWTriggerVolume> _trigger;

	private void OnDrawGizmosSelected()
	{
		if (_detector != null && _detector.GetComponent<BoxCollider>() != null)
		{
			Gizmos.color = Color.cyan;
			Gizmos.matrix = Matrix4x4.TRS(_detector.transform.position, _detector.transform.rotation, Vector3.one);
			Gizmos.DrawWireCube(new Vector3(0f, 0f, _hoverHeight), _detector.GetComponent<BoxCollider>().size);
		}
	}
}
