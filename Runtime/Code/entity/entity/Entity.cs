/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public abstract class Entity : MonoBehaviour, IComponent
{
    public string slug; //
    public string type; //

    /**
     * 
     */
    public Entity CreateEntity(object obj = null)
    {
        var json = JsonUtility.ToJson(obj);

        var e = Instantiate(this, GameObject.Find($"Entity/{type}").transform); //make this so it doesnt require set up.

        e.gameObject.SetActive(true);

        e.DataSync(json);

        e.InvokeCreated();
        e.InvokeChanged();

        return e;
    }
}
