/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public interface ISingletonListener<T> where T : Singleton<T>
{
    /**
     * 
     */
    public void OnSingletonChanged(T t);
}
