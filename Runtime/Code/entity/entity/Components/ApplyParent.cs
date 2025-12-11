/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class ApplyParent : MonoBehaviour, IComponent
{
    public string type; //

    /**
     * 
     */
    void OnCreatedPre()
    {
        var parent = GameObject.Find($"Entity/{type}");

        if (parent == null)
        {
            parent = new GameObject(type);
            parent.transform.parent = GameObject.Find("Entity").transform;
        }

        transform.SetParent(GameObject.Find($"Entity/{type}").transform, false);
    }
}
