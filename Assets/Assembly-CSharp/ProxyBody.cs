using UnityEngine;

public abstract class ProxyBody : MonoBehaviour
{
	[SerializeField]
	protected Transform _realObjectTransform;
	[SerializeField]
	protected float _realObjectDiameter;
}
