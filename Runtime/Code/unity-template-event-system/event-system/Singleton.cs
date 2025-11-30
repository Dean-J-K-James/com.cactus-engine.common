/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    public static T I { get; private set; } //

    /**
     * 
     */
    void Awake()
    {
        I = this as T;
    }
}