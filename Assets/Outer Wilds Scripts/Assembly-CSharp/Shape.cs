using UnityEngine;

public abstract class Shape : MonoBehaviour
{
	public enum CollisionMode
	{
		Volume = 0,
		Detector = 1,
		Manual = 2,
	}

	public enum Layer
	{
		Default = 1,
		Sector = 2,
		Gravity = 4,
		Light = 8,
	}

	[SerializeField]
	protected CollisionMode _collisionMode;
	[SerializeField]
	protected Layer _layer = Layer.Default;
	[SerializeField]
	protected int _layerMask = -1;
	[SerializeField]
	protected bool _pointChecksOnly;
}
