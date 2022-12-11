using UnityEngine;

public class EmergencyHatch : MonoBehaviour
{
	[SerializeField]
	private NomaiInterfaceSlot _openHatchSlot;
	[SerializeField]
	private NomaiInterfaceOrb _orb;
	[SerializeField]
	private float _ejectSpeed = 20f;
	[SerializeField]
	private Vector3 _localAngularVelocity = new Vector3(0f, 0f, 3f);
	[SerializeField]
	private Vector3 _localVelocityOffset;
}
