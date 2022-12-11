using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SubmitAction))]
[RequireComponent(typeof(Button))]
public class ButtonWithHotkeyImageElement : MonoBehaviour
{
	[SerializeField]
	private Text _buttonText;
	[SerializeField]
	private Image _buttonBorderImage;
	[SerializeField]
	private Image _hotkeyImageOne;
	[SerializeField]
	private Image _hotkeyImageTwo;
	[SerializeField]
	private GameObject _imageOneLayoutObject;
	[SerializeField]
	private GameObject _imageTwoLayoutObject;
	[Space(10f)]
	[SerializeField]
	private RectTransform _graphicElementsRootTransform;
	[SerializeField]
	private LayoutElement _hotkeyImageOneLayoutElement;
	[SerializeField]
	private LayoutElement _hotkeyImageTwoLayoutElement;
	[Space(10f)]
	[SerializeField]
	private LayoutElement _spacerElement;
	[SerializeField]
	private float _imageToTextElementSpacing = 10f;
}
