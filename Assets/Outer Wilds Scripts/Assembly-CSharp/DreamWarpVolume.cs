using UnityEngine;

public class DreamWarpVolume : MonoBehaviour
{
	[SerializeField]
	private Transform _destinationTransform;
	[SerializeField]
	private Sector _destinationSector;
	[SerializeField]
	private Transform _loopTransform;
	[Space]
	[SerializeField]
	private OWRenderer[] _fadeDepartRenderers = new OWRenderer[0];
	[SerializeField]
	private float _fadeDepartStartDist = 30f;
	[SerializeField]
	private float _fadeDepartEndDist = 20f;
	[Space]
	[SerializeField]
	private OWRenderer[] _fadeArriveRenderers = new OWRenderer[0];
	[SerializeField]
	private float _fadeArriveStartDist = 30f;
	[SerializeField]
	private float _fadeArriveEndDist = 20f;
	[Space]
	[SerializeField]
	private OWRenderer _fallFadeRenderer;
	[SerializeField]
	private float _fallFadeTriggerDist = 10f;
	[SerializeField]
	private OWTriggerVolume _limboVolume;
	[SerializeField]
	private float _fallFadeOutLength = 0.5f;
	[SerializeField]
	private float _fallFadeInLength = 0.5f;
	[SerializeField]
	private Transform _fallDestination;

	private void OnDrawGizmosSelected()
	{
		Gizmos.matrix = Matrix4x4.TRS(base.transform.position, base.transform.rotation, Vector3.one);
		Gizmos.color = Color.cyan;
		Gizmos.DrawRay(Vector3.zero, Vector3.up * 10f);
		Gizmos.DrawWireCube(Vector3.zero, new Vector3(20f, 20f, 0f));
		Vector3 vector = Vector3.back * _fadeDepartStartDist;
		Vector3 vector2 = Vector3.back * _fadeDepartEndDist;
		Gizmos.DrawLine(vector, vector2);
		Gizmos.DrawRay(vector, Vector3.up * 10f);
		Gizmos.DrawRay(vector2, Vector3.up * 10f);
		OWGizmos.DrawWireCircle(vector, Vector3.back, 10f);
		OWGizmos.DrawWireCircle(vector2, Vector3.back, 10f);
		Gizmos.color = new Color(1f, 0.5f, 0.5f, 1f);
		Vector3 vector3 = Vector3.down * _fallFadeTriggerDist + Vector3.back * _fadeDepartEndDist * 0.5f;
		Gizmos.DrawWireCube(vector3, new Vector3(20f, 0f, _fadeDepartEndDist));
		Gizmos.DrawLine(vector3 + Vector3.right * 10f + Vector3.back * _fadeDepartEndDist * 0.5f, vector3 + Vector3.left * 10f + Vector3.forward * _fadeArriveEndDist * 0.5f);
		Gizmos.DrawLine(vector3 + Vector3.left * 10f + Vector3.back * _fadeDepartEndDist * 0.5f, vector3 + Vector3.right * 10f + Vector3.forward * _fadeArriveEndDist * 0.5f);
		if (_destinationTransform != null)
		{
			Gizmos.matrix = Matrix4x4.TRS(_destinationTransform.position, _destinationTransform.rotation, Vector3.one);
			Gizmos.color = Color.green;
			Gizmos.DrawRay(Vector3.zero, Vector3.up * 10f);
			Gizmos.DrawWireCube(Vector3.zero, new Vector3(20f, 20f, 0f));
			Vector3 vector4 = Vector3.forward * _fadeArriveStartDist;
			Vector3 vector5 = Vector3.forward * _fadeArriveEndDist;
			Gizmos.DrawLine(vector4, vector5);
			Gizmos.DrawRay(vector4, Vector3.up * 10f);
			Gizmos.DrawRay(vector5, Vector3.up * 10f);
			OWGizmos.DrawWireCircle(vector4, Vector3.forward, 10f);
			OWGizmos.DrawWireCircle(vector5, Vector3.forward, 10f);
			Gizmos.color = new Color(1f, 0.5f, 0f, 1f);
			Vector3 vector6 = Vector3.down * _fallFadeTriggerDist + Vector3.forward * _fadeArriveEndDist * 0.5f;
			Gizmos.DrawWireCube(vector6, new Vector3(20f, 0f, _fadeArriveEndDist));
			Gizmos.DrawLine(vector6 + Vector3.right * 10f + Vector3.back * _fadeArriveEndDist * 0.5f, vector6 + Vector3.left * 10f + Vector3.forward * _fadeArriveEndDist * 0.5f);
			Gizmos.DrawLine(vector6 + Vector3.left * 10f + Vector3.back * _fadeArriveEndDist * 0.5f, vector6 + Vector3.right * 10f + Vector3.forward * _fadeArriveEndDist * 0.5f);
		}
		if (_loopTransform != null)
		{
			Gizmos.matrix = Matrix4x4.TRS(_loopTransform.position, _loopTransform.rotation, Vector3.one);
			Gizmos.color = Color.magenta;
			Gizmos.DrawRay(Vector3.zero, Vector3.up * 10f);
			Gizmos.DrawWireCube(Vector3.zero, new Vector3(20f, 20f, 0f));
		}
		if (_fallDestination != null)
		{
			Gizmos.matrix = Matrix4x4.TRS(_fallDestination.position, _fallDestination.rotation, Vector3.one);
			Gizmos.color = Color.red;
			Gizmos.DrawRay(Vector3.zero, Vector3.forward * 10f);
			OWGizmos.DrawWireCircle(Vector3.zero, Vector3.up, 10f);
		}
	}
}
