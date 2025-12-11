/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public static class InvokeLocal
{
    /**
     * 
     */
    public static void Invoke(GameObject go, string function)
    {
        go.SendMessage(function + "Pre", SendMessageOptions.DontRequireReceiver);
        go.SendMessage(function, SendMessageOptions.DontRequireReceiver);
        go.SendMessage(function + "Post", SendMessageOptions.DontRequireReceiver);
    }
}
