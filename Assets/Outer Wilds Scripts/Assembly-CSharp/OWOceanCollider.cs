using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
[RequireComponent(typeof(WaveHeightCalculator))]
public class OWOceanCollider : OWCustomCollider
{
	[SerializeField]
	private float _wavelessRadius = 500f;
}
