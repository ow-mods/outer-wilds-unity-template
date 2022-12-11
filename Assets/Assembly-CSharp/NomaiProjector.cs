using UnityEngine;

public class NomaiProjector : MonoBehaviour
{
	[SerializeField]
	private NomaiInterfaceSlot _controllingSlot;
	[SerializeField]
	private MeshRenderer[] _textRenderers = new MeshRenderer[0];
	[SerializeField]
	private float _fadeLength = 1f;
	[SerializeField]
	private float _startDelay = 1f;
	[SerializeField]
	private float _staggerDelay = 0.5f;
	[SerializeField]
	private bool _startVisible;
}
