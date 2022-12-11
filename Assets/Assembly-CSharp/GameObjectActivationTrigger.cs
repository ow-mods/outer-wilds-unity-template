using UnityEngine;

[RequireComponent(typeof(OWTriggerVolume))]
public class GameObjectActivationTrigger : MonoBehaviour
{
	[SerializeField]
	private bool _checkForTag;
	[SerializeField]
	private string _tag = "";
	[SerializeField]
	private GameObject[] _gameObjects = new GameObject[1];
	[SerializeField]
	private bool _fireOnEnter = true;
	[SerializeField]
	private bool _activeOnEnter = true;
	[SerializeField]
	private bool _fireOnExit;
	[SerializeField]
	private bool _activeOnExit;
}
