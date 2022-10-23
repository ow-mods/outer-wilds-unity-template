using UnityEngine;
using UnityEngine.Serialization;

public class ShipLogFactTriggerVolume : MonoBehaviour
{
	[FormerlySerializedAs("_dataPointID")]
	[SerializeField]
	private string _factID = string.Empty;
	[SerializeField]
	private bool _player = true;
	[SerializeField]
	private bool _probe;
}
