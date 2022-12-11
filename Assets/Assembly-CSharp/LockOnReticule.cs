using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class LockOnReticule : MonoBehaviour
{
	public enum LockState
	{
		LOCK,
		POSSIBLE_LOCK,
		OFF
	}

	public enum ArrowState
	{
		OUT,
		IN,
		OFF
	}

	[Header("Arrows")]
	[SerializeField]
	private GameObject _reticuleArrowRoot;
	[SerializeField]
	private Transform[] _reticuleArrowPivots;
	[SerializeField]
	private MeshRenderer[] _reticuleArrowMeshes;
	[Header("LockOn")]
	[SerializeField]
	private float _lockOnScalar = 1.25f;
	[SerializeField]
	private GameObject _reticuleLockOnRoot;
	[SerializeField]
	private MeshRenderer[] _reticuleLockOnMeshes;
	[Header("Highlight")]
	[SerializeField]
	private float _highlightScalar = 1.35f;
	[SerializeField]
	private GameObject _reticuleHighlightRoot;
	[SerializeField]
	private MeshRenderer[] _reticuleHighlightMeshes;
	[Header("Readout")]
	[SerializeField]
	private Transform _readoutScaleRoot;
	[SerializeField]
	private Text _readout;
	[Header("Relative Motion Lines")]
	[SerializeField]
	private UILineRenderer _lineX;
	[SerializeField]
	private UILineRenderer _lineY;
	[SerializeField]
	private ScreenPromptList _promptListBlock;
}
