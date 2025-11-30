/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public static class XEvents
{
    /**
     * 
     */
    public static void InvokeCreated(this MonoBehaviour go) { go.SendMessage("OnCreatedPre", SendMessageOptions.DontRequireReceiver); go.SendMessage("OnCreated", SendMessageOptions.DontRequireReceiver); go.SendMessage("OnCreatedPost", SendMessageOptions.DontRequireReceiver); }
    public static void InvokeChanged(this MonoBehaviour go) { go.SendMessage("OnChangedPre", SendMessageOptions.DontRequireReceiver); go.SendMessage("OnChanged", SendMessageOptions.DontRequireReceiver); }
    public static void InvokeDeleted(this MonoBehaviour go) { go.SendMessage("OnDeletedPre", SendMessageOptions.DontRequireReceiver); go.SendMessage("OnDeleted", SendMessageOptions.DontRequireReceiver); }

    public static void InvokeEvent<T>(this MonoBehaviour go, string k, T v) { go.SendMessage(k, v, SendMessageOptions.DontRequireReceiver); }

}
