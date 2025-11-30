/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public static class XGlobalChanged //no longer used i think.
{
    /**
     * 
     */
    public static void GlobalChanged<T>(this MonoBehaviour g, T p) where T : Singleton<T>
    {
        var o = Object.FindObjectsByType<SingletonListener>(FindObjectsSortMode.None); 
        

        
        foreach (var sl in o) 
        {
            var c = sl.GetComponents<ISingletonListener<T>>();

            foreach (var cc in c)
            {
                cc.OnSingletonChanged(p);
            }
        }
    }
}
