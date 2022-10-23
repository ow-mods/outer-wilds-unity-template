using UnityEngine;
using UnityEngine.UI;

public class KeyRebindingDisplayElement : MonoBehaviour
{
	[SerializeField]
	private Text _label;
	[Space(10f)]
	[SerializeField]
	private GameObject _gamepadBindingImage1Obj;
	[SerializeField]
	private GameObject _gamepadBindingImage2Obj;
	[SerializeField]
	private Image _gamepadBindingImage1;
	[SerializeField]
	private Image _gamepadBindingImage2;
	[Space(10f)]
	[SerializeField]
	private GameObject _keyboardMouseBindingBlockObj;
	[SerializeField]
	private GameObject _keyboardMouseBindingImage1Obj;
	[SerializeField]
	private GameObject _keyboardMouseBindingImage2Obj;
	[SerializeField]
	private Image _keyboardMouseBindingImage1;
	[SerializeField]
	private Image _keyboardMouseBindingImage2;
}
