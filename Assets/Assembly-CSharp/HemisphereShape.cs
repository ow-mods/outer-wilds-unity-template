using UnityEngine;

[AddComponentMenu("Shapes/Hemisphere Shape", 7)]
public class HemisphereShape : SphereShape
{
	[SerializeField]
	protected int _direction = 1;
	[SerializeField]
	protected bool _cap;
}
