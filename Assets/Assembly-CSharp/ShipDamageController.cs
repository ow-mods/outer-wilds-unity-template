using UnityEngine;

[RequireComponent(typeof(ImpactSensor))]
public class ShipDamageController : MonoBehaviour
{
	[Space(10f)]
	[SerializeField]
	private ExplosionController _explosion;
	[SerializeField]
	private OWTriggerVolume[] _shipTriggerVolumes;
	[SerializeField]
	private GameObject[] _stencils = new GameObject[0];
}
