using UnityEngine;

public class UrchinCactus : MonoBehaviour
{
	[SerializeField]
	private float _retractedRadius = 1f;
	[SerializeField]
	private float _extendedRadius = 3f;
	[SerializeField]
	private bool _previewExtended = true;
	[SerializeField]
	private GameObject _urchinModel;
	[SerializeField]
	private SphereCollider _hazardCollider;
	[SerializeField]
	private SphereCollider _physicalCollider;
	[SerializeField]
	private SandLevelController _sandSphere;
}
