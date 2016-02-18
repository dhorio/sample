using UnityEngine;
using System.Collections;

namespace Network
{
	public enum ProtocolType
	{
		GotoMain,
		GotoTitle,
		TextOnly,
        PlayerPosition,
        BulletFire,
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

    public struct PlayerPosition
    {
        public Player.Direction direction;
        public PlayerPosition(Player.Direction direction)
        {
            this.direction = direction;
        }
    }

    public struct BulletFire
    {
    }
}