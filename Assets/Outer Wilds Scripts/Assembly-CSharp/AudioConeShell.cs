using UnityEngine;

[AddComponentMenu("Audio/Audio Cone Shell", 300)]
public class AudioConeShell : SectoredMonoBehaviour
{
	[SerializeField]
	private Transform _audioTransform;
	[SerializeField]
	private float _bottomRadius;
	[SerializeField]
	private float _topRadius;
	[SerializeField]
	private float _height;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = (Gizmos.color = Color.yellow);
		Vector3 vector = base.transform.position + base.transform.up * _height * 0.5f;
		Vector3 vector2 = base.transform.position - base.transform.up * _height * 0.5f;
		OWGizmos.DrawWireCircle(vector, base.transform.up, _topRadius);
		OWGizmos.DrawWireCircle(vector2, base.transform.up, _bottomRadius);
		Gizmos.DrawLine(vector2, vector);
	}
}
