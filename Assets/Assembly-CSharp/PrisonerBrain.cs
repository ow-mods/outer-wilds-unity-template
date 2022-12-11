using UnityEngine;

public class PrisonerBrain : MonoBehaviour
{
	[SerializeField]
	private string _name = "Kaepora";
	[SerializeField]
	private GhostNode.NodeLayer _nodeLayer = GhostNode.NodeLayer.Red;
	[Space]
	[SerializeField]
	private PrisonerEffects _effects;
	[SerializeField]
	private OWTriggerVolume _blockMovementVolume;
	[SerializeField]
	private OWTriggerVolume _allowMovementVolume;
}
