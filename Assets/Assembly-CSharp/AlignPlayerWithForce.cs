using UnityEngine;

public class AlignPlayerWithForce : AlignWithForce
{
	[SerializeField]
	private DampedSpring2D _airWobbleSpring2D = new DampedSpring2D();
}
