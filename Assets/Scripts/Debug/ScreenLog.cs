using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ScreenLog : MonoBehaviour {

    private Rect rect;
	float time;
	GUIStyle style;

	// ログの記録
	private static Queue<string> logMsg = new Queue<string>();
	public static void log(string msg)
	{
		logMsg.Enqueue(msg);
	}

	void Awake()
	{
		style = new GUIStyle();
		style.fontSize = 14;
		style.fontStyle = FontStyle.Normal;
		style.normal.textColor = Color.white;

		rect = new Rect(0, 0, Screen.width, Screen.height);
	}

	// ログの出力
	void Update()
	{
		if (!logMsg.Any()) return;

		time += Time.deltaTime;
		if (time >= 1f / logMsg.Count)
		{
			logMsg.Dequeue();
			time = 0;
		}
	}

	// 記録されたログを画面出力する
	void OnGUI()
	{
        // 出力された文字列を改行でつなぐ
        string outMessage = string.Empty; 
		foreach (string msg in logMsg)
		{
			outMessage += msg + System.Environment.NewLine;
		}

		// 改行でつないだログメッセージを画面に出す
		GUI.Label(rect, outMessage, style);
	}
}
