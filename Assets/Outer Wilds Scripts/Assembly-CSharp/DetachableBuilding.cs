using UnityEngine;

public class DetachableBuilding : MonoBehaviour
{
	[SerializeField]
	private float _mass = 10f;
	[Space]
	[SerializeField]
	private ProxyShadowCaster[] _proxyShadowCasters = new ProxyShadowCaster[0];
}
