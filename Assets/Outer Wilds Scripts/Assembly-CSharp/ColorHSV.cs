using UnityEngine;

public struct ColorHSV
{
	public float h;

	public float s;

	public float v;

	public float a;

	public ColorHSV(float h, float s, float v, float a = 1f)
	{
		this.h = h;
		this.s = s;
		this.v = v;
		this.a = a;
	}

	public Color ToColorRGB()
	{
		if (s == 0f) return new Color(v, v, v, a);
		
		float num = h % 360f / 60f;
		int num2 = (int)num;
		float num3 = num - num2;
		float num4 = v;
		float num5 = num4 * (1f - s);
		float num6 = num4 * (1f - s * num3);
		float num7 = num4 * (1f - s * (1f - num3));
		Color result = new Color(0f, 0f, 0f, a);
		switch (num2)
		{
			case 0:
				result.r = num4;
				result.g = num7;
				result.b = num5;
				break;
			case 1:
				result.r = num6;
				result.g = num4;
				result.b = num5;
				break;
			case 2:
				result.r = num5;
				result.g = num4;
				result.b = num7;
				break;
			case 3:
				result.r = num5;
				result.g = num6;
				result.b = num4;
				break;
			case 4:
				result.r = num7;
				result.g = num5;
				result.b = num4;
				break;
			default:
				result.r = num4;
				result.g = num5;
				result.b = num6;
				break;
		}
		return result;
	}
}
