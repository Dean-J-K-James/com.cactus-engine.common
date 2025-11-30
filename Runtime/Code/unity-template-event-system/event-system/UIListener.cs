/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public abstract class UIListener<T> : MonoBehaviour
{
    /**
     * 
     */
    public abstract void OnChanged(T data);
}
