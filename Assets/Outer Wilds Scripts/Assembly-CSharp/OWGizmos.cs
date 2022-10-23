using System;
using System.Linq;
using UnityEngine;
using UnityEditor;

public static class OWGizmos
{
	public static bool IsDirectlySelected(GameObject gameObject)
	{
		return Selection.gameObjects.Contains(gameObject);
	}

	public static bool SelectionContainsComponentOfType<T>(bool includeInactive = false)
	{
		return Selection.gameObjects.Any(gameObject => gameObject.GetComponentsInChildren<T>(includeInactive).Any());
	}

	public static void DrawWireArc(Vector3 center, Vector3 normal, Vector3 from, float angle, float radius)
	{
		if (angle != 0f)
		{
			angle = Mathf.Clamp(angle, -360f, 360f);
			int num = Mathf.CeilToInt(Mathf.Abs(angle) * 0.125f);
			float num2 = (float)Math.PI * 2f / 45f * Mathf.Sign(angle);
			Quaternion quaternion = Quaternion.LookRotation(Vector3.Cross(normal, from), -normal);
			for (int i = 0; i < num - 1; i++)
			{
				Vector3 vector = new Vector3(Mathf.Cos((float)i * num2), 0f, Mathf.Sin((float)i * num2)) * radius;
				Vector3 vector2 = new Vector3(Mathf.Cos((float)(i + 1) * num2), 0f, Mathf.Sin((float)(i + 1) * num2)) * radius;
				Gizmos.DrawLine(center + quaternion * vector, center + quaternion * vector2);
			}
			Vector3 vector3 = new Vector3(Mathf.Cos((float)(num - 1) * num2), 0f, Mathf.Sin((float)(num - 1) * num2)) * radius;
			Vector3 vector4 = new Vector3(Mathf.Cos(angle * ((float)Math.PI / 180f)), 0f, Mathf.Sin(angle * ((float)Math.PI / 180f))) * radius;
			Gizmos.DrawLine(center + quaternion * vector3, center + quaternion * vector4);
		}
	}

	public static void DrawWireCircle(Vector3 center, Vector3 normal, float radius)
	{
		float num = (float)Math.PI * 2f / 45f;
		Vector3 rhs = ((Mathf.Abs(Vector3.Dot(normal, Vector3.up)) > 0.99f) ? Vector3.right : Vector3.up);
		Quaternion quaternion = Quaternion.LookRotation(Vector3.Cross(normal, rhs), -normal);
		for (int i = 0; i < 45; i++)
		{
			Vector3 vector = new Vector3(Mathf.Cos((float)i * num), 0f, Mathf.Sin((float)i * num)) * radius;
			Vector3 vector2 = new Vector3(Mathf.Cos((float)(i + 1) * num), 0f, Mathf.Sin((float)(i + 1) * num)) * radius;
			Gizmos.DrawLine(center + quaternion * vector, center + quaternion * vector2);
		}
	}

	public static void DrawBillboardedWireArc(Vector3 center, float fromAngle, float arcAngle, float radius)
	{
		Camera current = Camera.current;
		if (current != null)
		{
			Vector3 normal = -current.transform.forward;
			Vector3 right = current.transform.right;
			DrawWireArc(center, normal, right, arcAngle, radius);
		}
	}

	public static void DrawBillboardedWireCircle(Vector3 center, float radius)
	{
		Camera current = Camera.current;
		if (current != null)
		{
			DrawWireCircle(center, -current.transform.forward, radius);
		}
	}

	public static void DrawCylinder(Vector3 center, Quaternion rotation, float height, float radius)
	{
		Matrix4x4 matrix = Gizmos.matrix;
		Mesh mesh = Resources.Load<Mesh>("Editor/Models/GizmoCylinder");
		Gizmos.matrix = matrix * Matrix4x4.TRS(center, rotation, new Vector3(radius, height, radius));
		Gizmos.DrawMesh(mesh);
		Gizmos.matrix = matrix;
	}

	public static void DrawWireCylinder(Vector3 center, Quaternion rotation, float height, float radius)
	{
		Matrix4x4 matrix = Gizmos.matrix;
		Gizmos.matrix = matrix * Matrix4x4.TRS(center, rotation, Vector3.one);
		Vector3 vector = Vector3.up * height * 0.5f;
		Vector3 vector2 = -vector;
		DrawWireCircle(vector, Vector3.up, radius);
		DrawWireCircle(vector2, Vector3.down, radius);
		Gizmos.DrawLine(vector + Vector3.right * radius, vector2 + Vector3.right * radius);
		Gizmos.DrawLine(vector + Vector3.left * radius, vector2 + Vector3.left * radius);
		Gizmos.DrawLine(vector + Vector3.forward * radius, vector2 + Vector3.forward * radius);
		Gizmos.DrawLine(vector + Vector3.back * radius, vector2 + Vector3.back * radius);
		Gizmos.matrix = matrix;
	}

	public static void DrawWireCylinderOutline(Vector3 center, Quaternion rotation, float height, float radius)
	{
		Camera current = Camera.current;
		if (current != null)
		{
			Color color = Gizmos.color;
			Matrix4x4 matrix = Gizmos.matrix;
			Gizmos.matrix = matrix * Matrix4x4.TRS(center, rotation, Vector3.one);
			Vector3 lhs = Gizmos.matrix.MultiplyPoint3x4(Vector3.zero) - current.transform.position;
			Vector3 normalized = Gizmos.matrix.MultiplyVector(Vector3.up).normalized;
			float num = Mathf.Abs(Vector3.Dot(lhs.normalized, normalized));
			num = Mathf.Clamp01(num * 2f - 1f);
			Vector3 vector = Vector3.Cross(lhs, normalized);
			Vector3 vector2 = Vector3.Cross(normalized, vector);
			Vector3 vector3 = Vector3.up * height * 0.5f;
			Vector3 vector4 = -vector3;
			DrawWireCircle(vector3, Vector3.up, radius);
			DrawWireCircle(vector4, Vector3.down, radius);
			Gizmos.color = Color.Lerp(color, Color.clear, num * num);
			vector = Gizmos.matrix.inverse.MultiplyVector(vector).normalized;
			vector2 = Gizmos.matrix.inverse.MultiplyVector(vector2).normalized;
			Gizmos.DrawLine(vector3 + vector * radius, vector4 + vector * radius);
			Gizmos.DrawLine(vector3 - vector * radius, vector4 - vector * radius);
			Gizmos.color = color;
			Gizmos.matrix = matrix;
		}
	}

	public static void DrawWireHemisphere(Vector3 center, Quaternion rotation, float radius)
	{
		Matrix4x4 matrix = Gizmos.matrix;
		Gizmos.matrix = matrix * Matrix4x4.TRS(center, rotation, Vector3.one);
		DrawWireCircle(Vector3.zero, Vector3.up, radius);
		DrawWireArc(Vector3.zero, Vector3.right, Vector3.back, 180f, radius);
		DrawWireArc(Vector3.zero, Vector3.forward, Vector3.right, 180f, radius);
		Gizmos.matrix = matrix;
	}

	public static void DrawCapsule(Vector3 center, Quaternion rotation, float height, float radius)
	{
		Matrix4x4 matrix = Gizmos.matrix;
		Mesh mesh = Resources.Load<Mesh>("Editor/Models/GizmoCylinder");
		Mesh mesh2 = Resources.Load<Mesh>("Editor/Models/GizmoHemisphere");
		Gizmos.matrix = matrix * Matrix4x4.TRS(center, rotation, new Vector3(radius, height, radius));
		Gizmos.DrawMesh(mesh);
		Gizmos.matrix = matrix * Matrix4x4.TRS(center, rotation, Vector3.one * radius);
		Gizmos.DrawMesh(mesh2, Vector3.up * height / radius * 0.5f);
		Gizmos.DrawMesh(mesh2, Vector3.down * height / radius * 0.5f, Quaternion.AngleAxis(180f, Vector3.right));
		Gizmos.matrix = matrix;
	}

	public static void DrawWireCapsule(Vector3 center, Quaternion rotation, float height, float radius)
	{
		Matrix4x4 matrix = Gizmos.matrix;
		Gizmos.matrix = matrix * Matrix4x4.TRS(center, rotation, Vector3.one);
		Vector3 vector = Vector3.up * height * 0.5f;
		Vector3 vector2 = -vector;
		DrawWireCircle(vector, Vector3.up, radius);
		DrawWireCircle(vector2, Vector3.down, radius);
		Gizmos.DrawLine(vector + Vector3.right * radius, vector2 + Vector3.right * radius);
		Gizmos.DrawLine(vector + Vector3.left * radius, vector2 + Vector3.left * radius);
		Gizmos.DrawLine(vector + Vector3.forward * radius, vector2 + Vector3.forward * radius);
		Gizmos.DrawLine(vector + Vector3.back * radius, vector2 + Vector3.back * radius);
		DrawWireArc(vector, Vector3.right, Vector3.back, 180f, radius);
		DrawWireArc(vector, Vector3.forward, Vector3.right, 180f, radius);
		DrawWireArc(vector2, Vector3.left, Vector3.back, 180f, radius);
		DrawWireArc(vector2, Vector3.back, Vector3.right, 180f, radius);
		Gizmos.matrix = matrix;
	}

	public static void DrawWireCapsuleOutline(Vector3 center, Quaternion rotation, float height, float radius)
	{
		Camera current = Camera.current;
		if (current != null)
		{
			Color color = Gizmos.color;
			Matrix4x4 matrix = Gizmos.matrix;
			Gizmos.matrix = matrix * Matrix4x4.TRS(center, rotation, Vector3.one);
			Vector3 lhs = Gizmos.matrix.MultiplyPoint3x4(Vector3.zero) - current.transform.position;
			Vector3 normalized = Gizmos.matrix.MultiplyVector(Vector3.up).normalized;
			float num = Mathf.Abs(Vector3.Dot(lhs.normalized, normalized));
			num = Mathf.Clamp01(num * 2f - 1f);
			Vector3 vector = Vector3.Cross(lhs, normalized);
			Vector3 vector2 = Vector3.Cross(normalized, vector);
			Vector3 vector3 = Vector3.up * height * 0.5f;
			Vector3 vector4 = -vector3;
			Gizmos.color = Color.Lerp(Color.clear, color, num * num);
			DrawWireCircle(vector3, Vector3.up, radius);
			DrawWireCircle(vector4, Vector3.down, radius);
			Gizmos.color = Color.Lerp(color, Color.clear, num * num);
			vector = Gizmos.matrix.inverse.MultiplyVector(vector).normalized;
			vector2 = Gizmos.matrix.inverse.MultiplyVector(vector2).normalized;
			DrawWireArc(vector3, vector2, vector, -180f, radius);
			DrawWireArc(vector4, vector2, vector, 180f, radius);
			Gizmos.DrawLine(vector3 + vector * radius, vector4 + vector * radius);
			Gizmos.DrawLine(vector3 - vector * radius, vector4 - vector * radius);
			Gizmos.color = color;
			Gizmos.matrix = matrix;
		}
	}

	public static void DrawWireCone(Vector3 center, Quaternion rotation, float height, float topRadius, float bottomRadius)
	{
		Matrix4x4 matrix = Gizmos.matrix;
		Gizmos.matrix = matrix * Matrix4x4.TRS(center, rotation, Vector3.one);
		Vector3 vector = Vector3.up * height * 0.5f;
		Vector3 vector2 = -vector;
		DrawWireCircle(vector, Vector3.up, topRadius);
		DrawWireCircle(vector2, Vector3.down, bottomRadius);
		Gizmos.DrawLine(vector + Vector3.right * topRadius, vector2 + Vector3.right * bottomRadius);
		Gizmos.DrawLine(vector + Vector3.left * topRadius, vector2 + Vector3.left * bottomRadius);
		Gizmos.DrawLine(vector + Vector3.forward * topRadius, vector2 + Vector3.forward * bottomRadius);
		Gizmos.DrawLine(vector + Vector3.back * topRadius, vector2 + Vector3.back * bottomRadius);
		Gizmos.matrix = matrix;
	}
}
