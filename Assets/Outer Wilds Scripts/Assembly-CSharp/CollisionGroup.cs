using UnityEngine;
using System.Collections.Generic;

[AddComponentMenu("Sectors/Collision Group", 299)]
public class CollisionGroup : MonoBehaviour
{
	[SerializeField]
	[HideInInspector]
	private bool _prebuilt;
	[SerializeField]
	[HideInInspector]
	private List<OWCollider> _colliders;
	[SerializeField]
	[HideInInspector]
	private List<Shape> _shapes;
}
