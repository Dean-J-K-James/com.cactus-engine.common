/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public static class InvokeGlobal
{
    /**
     * 
     */
    public static void Invoke(string function)
    {
        foreach (GameObject go in Object.FindObjectsByType<GameObject>(FindObjectsSortMode.None))
        {
            if (go != null && go.activeSelf)
            {
                InvokeLocal.Invoke(go, function);
            }
        }
    }
}
