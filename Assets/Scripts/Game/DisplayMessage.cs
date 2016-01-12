using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayMessage : MonoBehaviour {

    [SerializeField]
    InputField input;

	// Use this for initialization
	void Start () {
        MainSystem.Instance.Executor.OnReceiveTextMessage += OnReceiveTextMessage;
    }

    void OnDestroy()
    {
        MainSystem.Instance.Executor.OnReceiveTextMessage -= OnReceiveTextMessage;
    }

    void OnReceiveTextMessage(Network.TextMessage message)
    {
        Debug.Log(message.text);
    }

    public void SendTextMessage()
    {
        MainSystem.Instance.Session.SendTextMessage(input.text);
        input.text = string.Empty;
    }
}
