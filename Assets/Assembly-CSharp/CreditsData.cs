using System;
using System.Collections.Generic;
using System.Xml.Serialization;

public class CreditsData
{
	[Serializable]
	public class CreditsLine
	{
		public enum XAlign
		{
			RowCenter,
			TextCenter
		}

		[XmlAttribute("m_style")]
		public string m_style = "Text";
		[XmlAttribute("m_yOffset")]
		public float m_yOffset;
		[XmlAttribute("m_string")]
		public string m_string;
	}

	[Serializable]
	public class CreditsPage
	{
		public enum YAlign
		{
			TOP = 0,
			MIDDLE = 1,
			BOTTOM = 2,
		}

		[XmlElement("m_yAlign")]
		public YAlign m_yAlign;
		[XmlElement("m_lines")]
		public List<CreditsData.CreditsLine> m_lines;
		[XmlElement("m_scrollSpeed")]
		public float m_scrollSpeed;
		[XmlElement("m_scrollDuration")]
		public float m_scrollDuration;
		[XmlElement("m_displayTime")]
		public float m_displayTime = 2f;
		[XmlElement("m_waitTime")]
		public float m_waitTime;
	}

	[Serializable]
	[XmlRoot("Credits")]
	public class Credits
	{
		[XmlElement("m_fadeInTime")]
		public float m_fadeInTime = 0.5f;
		[XmlElement("m_fadeOutTime")]
		public float m_fadeOutTime = 0.5f;
		[XmlElement("m_ySpacing")]
		public float m_ySpacing;
		[XmlElement("m_pages")]
		public List<CreditsPage> m_pages;
	}

}
