using UnityEngine;
using System.Collections.Generic;

public class FragmentIntegrity : MonoBehaviour
{
	[SerializeField]
	protected float _integrity = 20f;
	[SerializeField]
	private float _randomIntegrityRange = 5f;
	[SerializeField]
	protected float _damageMultiplier = 1f;
	[SerializeField]
	private float _minImpactMass = 0.01f;
	[SerializeField]
	private float _maxImpactMass = 1f;
	[SerializeField]
	private float _minImpactSpeed = 10f;
	[SerializeField]
	private float _maxImpactSpeed = 100f;
	[SerializeField]
	private List<FragmentIntegrity> _childFragmentList;
	[SerializeField]
	private bool _breakWithLastChild;
	[SerializeField]
	private bool _ignoreMeteorDamage;
}
