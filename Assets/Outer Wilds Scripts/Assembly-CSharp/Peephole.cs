using UnityEngine;
using UnityEngine.PostProcessing;

public class Peephole : MonoBehaviour
{
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private OWCamera _peepholeCamera;
	[SerializeField]
	private PostProcessingBehaviour _peepholeCameraPostProcessing;
	[SerializeField]
	private Sector _viewingSector;
	[SerializeField]
	private OWRenderer _hideWhileViewing;
	[Space]
	[SerializeField]
	private float _enterTransitionInLength = 0.25f;
	[SerializeField]
	private float _exitTransitionOutLength = 0.15f;
	[SerializeField]
	private float _exitZoomOutLength = 0.5f;
	[Space]
	[SerializeField]
	private float _enterCloseEyesLength = 0.25f;
	[SerializeField]
	private float _enterOpenEyesLength = 0.25f;
	[SerializeField]
	private float _exitCloseEyesLength = 0.25f;
	[SerializeField]
	private float _exitOpenEyesLength = 0.25f;
	[Space]
	[SerializeField]
	private string[] _factIDs = new string[0];
}
