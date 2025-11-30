/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class Asset : Singleton<Asset>
{
    /**
	 * 
	 */
    public T Get<T>(string k) where T : MonoBehaviour { var obj = transform.Find(k); return obj != null ? obj.GetComponent<T>() : null; }

    public T[] All<T>() where T : MonoBehaviour
    {
        return transform.GetComponentsInChildren<T>(true);
    }
}