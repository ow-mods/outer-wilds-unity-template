using UnityEngine;

public class BridgeFragmentController : MonoBehaviour
{
	[SerializeField]
	private Sector _sector;
	[Space]
	[SerializeField]
	private Transform _snapTarget;
	[Space]
	[SerializeField]
	private Shape _detectorShape;
}
