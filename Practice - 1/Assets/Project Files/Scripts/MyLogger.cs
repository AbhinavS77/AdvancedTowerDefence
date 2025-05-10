using UnityEngine;
public static class MyLogger
{
#if UNITY_EDITOR
    /// <summary>
    /// This is alternative to Degub.Log
    /// </summary>
    /// <param name="message"> 
    /// ok guys
    /// </param>
    public static void Log(object message)
    {
        Debug.Log(message);
    }
    public static void LogWarning(object message)
    {
        Debug.LogWarning(message);
    }
    public static void LogError(object message)
    {
        Debug.LogError(message);
    }
#else
    public static void Log(object message){}
    public static void LogWarning(object message){}
    public static void LogError(object message){}
#endif
}
