using UnityEngine;

public class SetActiveOnAwake : MonoBehaviour
{
	[SerializeField]
	private GameObject[] _targets = new GameObject[0];
	[SerializeField]
	private bool _active;
}
