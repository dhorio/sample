using UnityEngine;
using System.Collections;

namespace Network
{
	public enum ProtocolType
	{
		GotoMain,
		GotoTitle,
		TextOnly,
	};

	public struct Msg
	{
		public ProtocolType type;
		public byte[] data;

		public Msg(ProtocolType type, byte[] data)
		{
			this.type = type;
			this.data = data;
		}
		public Msg(ProtocolType type)
		{
			this.type = type;
			data = null;
		}
	}

	public struct TextMessage
	{
		public string text;
		public TextMessage(string text)
		{
			this.text = text;
		}
	}
}