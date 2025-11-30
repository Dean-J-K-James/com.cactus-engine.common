/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class ClearPlayerPrefs : MonoBehaviour
{
    /**
     * 
     */
    void Awake() => PlayerPrefs.DeleteAll();
}
