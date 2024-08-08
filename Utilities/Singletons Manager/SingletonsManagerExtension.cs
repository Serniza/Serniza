using Utilities;

public static class SingletonsManagerExtension
{
    public static T GetSingleton<T>(this UnityEngine.MonoBehaviour monoBehaviour) where T: UnityEngine.MonoBehaviour
    {
        return SingletonsManager._instance.GetSingleton<T>();
    }

    public static T GetSingleton<T>(this ScriptableObject scriptableObject) where T : UnityEngine.MonoBehaviour
    {
        return SingletonsManager._instance.GetSingleton<T>();
    }
}
