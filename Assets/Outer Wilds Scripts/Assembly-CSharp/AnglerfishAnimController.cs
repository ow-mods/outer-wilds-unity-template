using UnityEngine;

public class AnglerfishAnimController : MonoBehaviour
{
	[SerializeField]
	private AnglerfishController _anglerfishController;
	[Space]
	[SerializeField]
	private float _moveChangeSpeed = 1f;
	[Space]
	[SerializeField]
	private float _jawOpenSpeed = 1f;
	[SerializeField]
	private float _jawCloseSpeed = 1f;
	[Space]
	[SerializeField]
	private float _spinesFlareSpeed = 1f;
	[SerializeField]
	private float _spinesFlareVariation = 1f;
	[SerializeField]
	private Transform[] _spines = new Transform[0];
	[Space]
	[SerializeField]
	private float _lookSpeed = 1f;
}
