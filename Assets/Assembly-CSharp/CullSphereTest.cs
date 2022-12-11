using UnityEngine;

public class CullSphereTest : MonoBehaviour
{
	public bool occluder;
	public float radius = 0.5f;

	public SphereBounds GetSphereBounds()
	{
		return new SphereBounds(base.transform.position, radius);
	}

	public void OnDrawGizmos()
	{
		Camera current = Camera.current;
		CullSphereTest[] array = Object.FindObjectsOfType<CullSphereTest>();
		foreach (CullSphereTest cullSphereTest in array)
		{
			if (!(cullSphereTest == this) && cullSphereTest.occluder && cullSphereTest.GetSphereBounds().Occludes(GetSphereBounds(), current.transform.position))
			{
				Gizmos.color = Color.red;
				break;
			}
		}
		if (occluder)
		{
			Gizmos.DrawWireSphere(base.transform.position, radius);
		}
		else
		{
			Gizmos.DrawSphere(base.transform.position, radius);
		}
	}
}
