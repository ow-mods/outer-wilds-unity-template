using UnityEngine;
using UnityEngine.Serialization;
using System.Collections.Generic;

public class SocketedQuantumObject : QuantumObject
{
	[SerializeField]
	private Vector3 _localOffset = Vector3.zero;
	[SerializeField]
	private float _newlyObscuredSocketProbability = 1f;
	[FormerlySerializedAs("_quantumSockets")]
	[SerializeField]
	private QuantumSocket[] _sockets;
	[FormerlySerializedAs("_quantumSocketRoot")]
	[SerializeField]
	private GameObject _socketRoot;
	[SerializeField]
	private bool _alignWithGravity = true;
	[SerializeField]
	private bool _alignWithSocket;
	[FormerlySerializedAs("_rotateOnCollapse")]
	[SerializeField]
	private bool _randomYRotation = true;
	[SerializeField]
	[HideInInspector]
	private bool _prebuilt;
	[SerializeField]
	[HideInInspector]
	private List<QuantumSocket> _socketList;
	[SerializeField]
	[HideInInspector]
	private List<QuantumSocket> _childSockets;
}
