using System;

public struct LightPulse
{
	public bool illuminated;
	public bool isLong;

	public LightPulse(bool illuminated, float duration)
	{
		this.illuminated = illuminated;
		this.isLong = duration > 0.7f && duration <= 3f;
	}

	public LightPulse(bool illuminated, bool isLong)
	{
		this.illuminated = illuminated;
		this.isLong = isLong;
	}
}
