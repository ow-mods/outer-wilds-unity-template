using UnityEngine;
using UnityEngine.UI;

public class SleepTimerUI : MonoBehaviour
{
	[SerializeField]
	private Canvas _canvas;
	[SerializeField]
	private Text _text;
	[Space]
	[SerializeField]
	private Transform _emberRoot;
	[SerializeField]
	private Vector2 _emberDelay = new Vector2(0f, 3f);
	[Space]
	[SerializeField]
	private Vector2 _constantForce = new Vector2(0f, 100f);
	[SerializeField]
	private Vector2 _noiseForce = new Vector2(100f, 100f);
	[SerializeField]
	private Vector2 _noiseScreenScale = new Vector2(2f, 2f);
	[SerializeField]
	private Vector2 _noiseTimeScale = new Vector2(1f, 1f);
	[Space]
	[SerializeField]
	private Vector2 _randomScale = new Vector2(0.9f, 1.1f);
	[SerializeField]
	private Gradient _randomTint = new Gradient();
	[SerializeField]
	private Gradient _dreamFireRandomTint = new Gradient();
	[SerializeField]
	private Vector2 _heatVelRange = new Vector2(0f, 100f);
	[SerializeField]
	private Gradient _heatTint = new Gradient();
	[SerializeField]
	private Gradient _dreamFireHeatTint = new Gradient();
	[SerializeField]
	private Material _defaultEmberMaterial;
	[SerializeField]
	private Material _dreamEmberMaterial;
}
