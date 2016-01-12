using UnityEngine;
using System;
using System.Collections;

namespace Network
{
    public class Executor
    {
        public Action<TextMessage> OnReceiveTextMessage = (msg) => { };
        public Action<PlayerPosition> OnReceivePlayerPosition = (msg) => { };

        public void DoProtocol(Msg msg)
        {
            switch (msg.type)
            {
                case ProtocolType.GotoMain:
                    Application.LoadLevelAsync("main");
                    break;

                case ProtocolType.GotoTitle:
                    Application.LoadLevelAsync("title");
                    break;

                case ProtocolType.TextOnly:
                    var data = Packer.UnPack<TextMessage>(msg.data);
                    OnReceiveTextMessage(data);
                    break;
                case ProtocolType.PlayerPosition:
                    OnReceivePlayerPosition(Packer.UnPack<PlayerPosition>(msg.data));
                    break;
            }
        }
    }
}