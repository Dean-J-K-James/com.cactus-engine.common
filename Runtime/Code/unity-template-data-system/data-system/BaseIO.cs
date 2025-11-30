/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class BaseIO : MonoBehaviour, IComponent
{
    public string playerPrefsKey; //

    /**
     * 
     */

    void OnCreatedPre() => this.DataSync(PlayerPrefs.GetString(playerPrefsKey, "{}"));
    void OnChangedPre() => PlayerPrefs.SetString(playerPrefsKey, JsonUtility.ToJson(this));
}
