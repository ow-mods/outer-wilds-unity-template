using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[AddComponentMenu("Event/Tracked Device Raycaster")]
[RequireComponent(typeof(Canvas))]
public class TrackedDeviceRaycaster : BaseRaycaster
{
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
	{
	}

	public override Camera eventCamera
	{
		get { return default(Camera); }
	}

	[FormerlySerializedAs("ignoreReversedGraphics")]
	[SerializeField]
	private bool m_IgnoreReversedGraphics;
	[FormerlySerializedAs("checkFor2DOcclusion")]
	[SerializeField]
	private bool m_CheckFor2DOcclusion;
	[FormerlySerializedAs("checkFor3DOcclusion")]
	[SerializeField]
	private bool m_CheckFor3DOcclusion;
	[Tooltip("Maximum distance (in 3D world space) that rays are traced to find a hit.")]
	[SerializeField]
	private float m_MaxDistance = 1000f;
	[SerializeField]
	private LayerMask m_BlockingMask;
}
