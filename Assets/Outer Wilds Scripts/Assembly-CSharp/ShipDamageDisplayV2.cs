using UnityEngine;

public class ShipDamageDisplayV2 : MonoBehaviour
{
	[SerializeField]
	private ShipHull[] _shipHulls = new ShipHull[8];
	[SerializeField]
	private ShipComponent[] _shipComponents = new ShipComponent[16];
}
