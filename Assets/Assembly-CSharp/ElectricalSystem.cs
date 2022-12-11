using UnityEngine;

public class ElectricalSystem : MonoBehaviour
{
	[SerializeField]
	private ElectricalSystem[] _connectedSystems = new ElectricalSystem[0];
	[SerializeField]
	private ElectricalComponent[] _connectedComponents = new ElectricalComponent[0];
	[SerializeField]
	private float _systemDelay;

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.blue;
		for (int i = 0; i < _connectedSystems.Length; i++)
		{
			if (_connectedSystems[i] != null)
			{
				Gizmos.DrawLine(base.transform.position, _connectedSystems[i].transform.position);
			}
		}
		Gizmos.color = Color.red;
		for (int j = 0; j < _connectedComponents.Length; j++)
		{
			if (_connectedComponents[j] != null)
			{
				Gizmos.DrawLine(base.transform.position, _connectedComponents[j].transform.position);
			}
		}
	}
}
