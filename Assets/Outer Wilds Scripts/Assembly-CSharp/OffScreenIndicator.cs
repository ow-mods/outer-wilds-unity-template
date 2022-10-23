using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
public class OffScreenIndicator : MonoBehaviour
{
	[SerializeField]
	private Text _textField;
	[SerializeField]
	private RectTransform _arrow;
	[SerializeField]
	private float _screenMargin = 20f;
}
