using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipLogSlideProjector : MonoBehaviour
{
	[SerializeField]
	private Image _slideImage;
	[SerializeField]
	private CanvasGroupAnimator _animator;
	[SerializeField]
	private GameObject _promptRoot;
	[SerializeField]
	private ScreenPromptList _promptList;
	[SerializeField]
	private OWAudioSource _oneShotSource;
	[SerializeField]
	private Text _reelCounter;
}