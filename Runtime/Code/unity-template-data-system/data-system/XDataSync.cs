/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public static class XDataSync
{
    /**
     * 
     */
    public static void DataSync(this MonoBehaviour mb, string json) { foreach (var c in mb.GetComponents<IComponent>()) { JsonUtility.FromJsonOverwrite(json, c); } }
}
