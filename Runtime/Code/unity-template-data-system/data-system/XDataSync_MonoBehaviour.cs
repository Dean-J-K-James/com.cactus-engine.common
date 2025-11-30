/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public static class XDataSync_MonoBehaviour
{
    /**
     * 
     */
    public static void DataSync(this MonoBehaviour mb) { mb.DataSync(JsonUtility.ToJson(mb)); }
}
