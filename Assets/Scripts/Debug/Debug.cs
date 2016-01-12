using UnityEngine;

public static class Debug
{
	static public void Break()
	{
		UnityEngine.Debug.Break();
	}


	public static void DrawLine(Vector3 start, Vector3 end)
	{
		UnityEngine.Debug.DrawLine(start, end);
	}
	public static void DrawLine(Vector3 start, Vector3 end, Color color)
	{
		UnityEngine.Debug.DrawLine(start, end, color);
	}
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
	{
		UnityEngine.Debug.DrawLine(start, end, color, duration);
	}
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest)
	{
		UnityEngine.Debug.DrawLine(start, end, color, duration, depthTest);
	}



	public static void DrawRay(Vector3 start, Vector3 dir)
	{
		UnityEngine.Debug.DrawRay(start, dir);
	}
	public static void DrawRay(Vector3 start, Vector3 dir, Color color)
	{
		UnityEngine.Debug.DrawRay(start, dir, color);
	}
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
	{
		UnityEngine.Debug.DrawRay(start, dir, color, duration);
	}
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest)
	{
		UnityEngine.Debug.DrawRay(start, dir, color, duration, depthTest);
	}


	static public void Log(object message)
	{
		UnityEngine.Debug.Log(message);
		ScreenLog.log(message.ToString());
	}
	static public void Log(object message, Object context)
	{
		UnityEngine.Debug.Log(message, context);
		ScreenLog.log(message.ToString());
	}



	static public void LogWarning(object message)
	{
		UnityEngine.Debug.LogWarning(message);
		ScreenLog.log(message.ToString());
	}
	static public void LogWarning(object message, Object context)
	{
		UnityEngine.Debug.LogWarning(message, context);
		ScreenLog.log(message.ToString());
	}



	static public void LogError(object message)
	{
		UnityEngine.Debug.LogError(message);
		ScreenLog.log(message.ToString());
	}
	static public void LogError(object message, Object context)
	{
		UnityEngine.Debug.LogError(message, context);
		ScreenLog.log(message.ToString());
	}
}