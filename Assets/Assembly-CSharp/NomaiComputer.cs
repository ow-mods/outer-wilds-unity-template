using UnityEngine;

[RequireComponent(typeof(CapsuleCollider))]
public class NomaiComputer : NomaiText
{
	[SerializeField]
	private bool _startActivated;
	[SerializeField]
	private float _dockedHeight;
	[SerializeField]
	private float _minHeight = 0.5f;
	[SerializeField]
	private float _maxHeight = 2f;
	[Space(10f)]
	[SerializeField]
	private OWAudioSource _ambientAudioSource;
	[SerializeField]
	private OWAudioSource _oneShotAudioSource;
	[SerializeField]
	private float _fadeLength = 0.5f;

	private void OnDrawGizmosSelected()
	{
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Gizmos.color = Color.red;
		OWGizmos.DrawWireCircle(Vector3.up * _dockedHeight, Vector3.up, 1.5f);
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(Vector3.up * _minHeight, Vector3.up * _maxHeight);
		Gizmos.DrawRay(Vector3.up * _minHeight, Vector3.forward * 1.25f);
		Gizmos.DrawRay(Vector3.up * _maxHeight, Vector3.forward * 1f);
		OWGizmos.DrawWireCircle(Vector3.up * _minHeight, Vector3.up, 1.25f);
		OWGizmos.DrawWireCircle(Vector3.up * _maxHeight, Vector3.up, 1f);
	}
}
