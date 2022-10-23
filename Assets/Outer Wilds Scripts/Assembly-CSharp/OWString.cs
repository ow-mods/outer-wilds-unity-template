using System;

[Serializable]
public class OWString
{
	public string Value;

	public OWString()
	{
		Value = string.Empty;
	}

	public OWString(string str)
	{
		Value = str;
	}
}
