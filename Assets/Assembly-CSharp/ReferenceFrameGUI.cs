using UnityEngine;

public class ReferenceFrameGUI : MonoBehaviour
{
	private enum ReferenceFrameGUIType
	{
		PLAYER = 0,
		SHIP = 1,
		LANDING_CAM = 2,
		MAP = 3,
	}

	[SerializeField]
	private Canvas _canvas;
	[SerializeField]
	private Canvas _referenceCanvas;
	[SerializeField]
	private OWRigidbody _activeBody;
	[SerializeField]
	private OWCamera _activeCam;
	[SerializeField]
	private LockOnReticule _reticule1;
	[SerializeField]
	private LockOnReticule _reticule2;
	[SerializeField]
	private Color _departingColor = new Color(1f, 0f, 0f, 1f);
	[SerializeField]
	private Color _approachingColor = new Color(0f, 1f, 0.333f, 1f);
	[SerializeField]
	private Color _staticColor = Color.white;
	[SerializeField]
	private float _possLockReticuleAlpha = 0.25f;
	[SerializeField]
	private OffScreenIndicator _offScreenIndicator;
	[SerializeField]
	private ReferenceFrameGUIType _type;
}
