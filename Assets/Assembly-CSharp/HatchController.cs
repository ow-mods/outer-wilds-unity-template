using UnityEngine;

[RequireComponent(typeof(InteractVolume))]
public class HatchController : MonoBehaviour
{
	[SerializeField]
	private OWTriggerVolume _triggerVolume;
	[SerializeField]
	private GameObject _hatchObject;
	[SerializeField]
	private Transform _hatch;
	[SerializeField]
	private float _hatchOpenTime;
	[SerializeField]
	private Vector3 _hatchClosedRotation = new Vector3(180f, 0f, 0f);
	[SerializeField]
	private Vector3 _hatchOpenedRotation = Vector3.zero;
}
