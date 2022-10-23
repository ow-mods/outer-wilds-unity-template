using UnityEngine;

public class VolumeOcclusionLight : MonoBehaviour
{
	[SerializeField]
	private Vector2 _startSize = new Vector2(1f, 1f);
	[SerializeField]
	private Vector2 _endSize = new Vector2(1.5f, 1.5f);
	[SerializeField]
	private float _range = 1f;
	[SerializeField]
	[Range(0f, 1f)]
	private float _intensity = 1f;
	[SerializeField]
	private Texture2D _cookie;
	[SerializeField]
	private bool _distanceBlur = true;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = new Color(1f, 1f, 1f, 1f);
		Gizmos.matrix = base.transform.localToWorldMatrix;
		Vector2 vector = _startSize * 0.5f;
		Vector2 vector2 = _endSize * 0.5f;
		Gizmos.DrawLine(new Vector3(0f - vector.x, 0f - vector.y, 0f), new Vector3(vector.x, 0f - vector.y, 0f));
		Gizmos.DrawLine(new Vector3(vector.x, 0f - vector.y, 0f), new Vector3(vector.x, vector.y, 0f));
		Gizmos.DrawLine(new Vector3(0f - vector.x, 0f - vector.y, 0f), new Vector3(0f - vector.x, vector.y, 0f));
		Gizmos.DrawLine(new Vector3(0f - vector.x, vector.y, 0f), new Vector3(vector.x, vector.y, 0f));
		Gizmos.DrawLine(new Vector3(0f - vector2.x, 0f - vector2.y, _range), new Vector3(vector2.x, 0f - vector2.y, _range));
		Gizmos.DrawLine(new Vector3(vector2.x, 0f - vector2.y, _range), new Vector3(vector2.x, vector2.y, _range));
		Gizmos.DrawLine(new Vector3(0f - vector2.x, 0f - vector2.y, _range), new Vector3(0f - vector2.x, vector2.y, _range));
		Gizmos.DrawLine(new Vector3(0f - vector2.x, vector2.y, _range), new Vector3(vector2.x, vector2.y, _range));
		Gizmos.DrawLine(new Vector3(0f - vector.x, 0f - vector.y, 0f), new Vector3(0f - vector2.x, 0f - vector2.y, _range));
		Gizmos.DrawLine(new Vector3(vector.x, 0f - vector.y, 0f), new Vector3(vector2.x, 0f - vector2.y, _range));
		Gizmos.DrawLine(new Vector3(0f - vector.x, vector.y, 0f), new Vector3(0f - vector2.x, vector2.y, _range));
		Gizmos.DrawLine(new Vector3(vector.x, vector.y, 0f), new Vector3(vector2.x, vector2.y, _range));
	}
}
