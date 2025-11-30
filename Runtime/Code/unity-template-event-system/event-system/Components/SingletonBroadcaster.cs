/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class SingletonBroadcaster<T> : MonoBehaviour where T : Singleton<T>
{
    //protected virtual void OnChanged()
    //{
    //    this.GlobalChanged<T>(this as T);
    //}
}
