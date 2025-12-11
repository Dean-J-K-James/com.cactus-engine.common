/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class Entity : MonoBehaviour, IComponent
{
    public string slug; //
    public string type; //

    /**
     * 
     */
    public Entity CreateEntity(object obj = null)
    {
        var json = JsonUtility.ToJson(obj);

        var e = Instantiate(this/*, GameObject.Find($"Entity/{type}").transform*/); //make this so it doesnt require set up. have a component that takes the type, finds the GO and sets parent to it.
        //maybe create parent gameobjects for each layer, rather than hard coding them all in.

        e.gameObject.SetActive(true);

        e.DataSync(json);

        e.InvokeCreated();
        e.InvokeChanged();

        return e;
    }
}
