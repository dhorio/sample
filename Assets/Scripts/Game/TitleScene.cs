using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Net;

public class TitleScene : MonoBehaviour
{

	[SerializeField]
	Text serverAddressText;
	[SerializeField]
	InputField clientAddress;

	void Start()
	{
		serverAddressText.text = IPAddress.Parse(UnityEngine.Network.player.ipAddress).ToString();
		clientAddress.text = serverAddressText.text;
	}

	public void ServerStart()
	{
		MainSystem.Instance.ListenStart();
	}

	public void ClientStart()
	{
        if (clientAddress.text == string.Empty) return;

		MainSystem.Instance.ConnectRequest(clientAddress.text);
	}
}