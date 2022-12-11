using UnityEngine;

public class MakeChildrenFragments : MonoBehaviour
{
	[SerializeField]
	private float _integrity = 100f;
	[SerializeField]
	private float _propagateToChildFraction = 1f;
	[SerializeField]
	private Material _fractureMaterial;
	[SerializeField]
	private float _fractionDetachable = 1f;
	[SerializeField]
	private float _drag = 10f;
	[SerializeField]
	private DetachableFragment.ForceMask _forceDetection = DetachableFragment.ForceMask.ParentOnly;
	[Space]
	[SerializeField]
	private bool _addCullGroup;
	[SerializeField]
	private Sector _cullGroupSector;
	[SerializeField]
	private bool _addCollisionGroup;
	[SerializeField]
	private Sector _collisionGroupSector;
	[SerializeField]
	private bool _addLightGroup;
	[SerializeField]
	private Sector _lightGroupSector;
}
