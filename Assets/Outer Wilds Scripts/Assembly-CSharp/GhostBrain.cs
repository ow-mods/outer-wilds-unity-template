using UnityEngine;

public class GhostBrain : MonoBehaviour
{
	[SerializeField]
	private bool _debug;
	[SerializeField]
	private string _name = "Pazuzu";
	[SerializeField]
	private bool _startWithLanternConcealed;
	[SerializeField]
	private GhostNode.NodeLayer _nodeLayer = GhostNode.NodeLayer.Red;
	[SerializeField]
	private GhostAction.Name[] _actions;
	[SerializeField]
	private GhostEffects _effects;
	[Header("Call for help behavior")]
	[SerializeField]
	private GhostBrain[] _helperGhosts;
	[SerializeField]
	private OWTriggerVolume _guardVolume;
	[SerializeField]
	private Transform _chokePoint;
	[Header("Reduced Frights Overrides")]
	[SerializeField]
	private bool _reducedFrights_allowChase;
}
