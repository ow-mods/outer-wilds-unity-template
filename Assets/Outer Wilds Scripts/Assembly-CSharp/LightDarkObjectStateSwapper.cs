using UnityEngine;

[RequireComponent(typeof(LightSensor))]
public class LightDarkObjectStateSwapper : MonoBehaviour
{
	[SerializeField]
	private GameObject _lightStateRoot;
}
