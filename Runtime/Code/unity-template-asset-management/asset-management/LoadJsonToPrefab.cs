/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using System;
using System.Collections;
using UnityEngine;

/**
 * 
 */
public class LoadJsonToPrefab : MonoBehaviour
{
    public GameObject emptyGO;     //
    public string     sceneToLoad; //

    /**
     * 
     */
    IEnumerator Start()
    {
        foreach (var prefab in Resources.LoadAll<TextAsset>("Entities/"))
        {
            CreatePrefabList(prefab.name.Split('.'));
            yield return new WaitForSeconds(0.05f);
        }

        DeletePrefabs();
        yield return null;
        RenamePrefabs();
        yield return null;
        InvokePrefabs();
        yield return null;

        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
    }

    /**
     * 
     */
    void CreatePrefabList(string[] names)
    {
        GameObject prefab = emptyGO;

        for (int i = 0; i < names.Length; i++)
        {
            prefab = CreateEntity(prefab, string.Join(".", names[0..(i + 1)]));
        }
    }

    /**
     * 
     */
    GameObject CreateEntity(GameObject prefab, string name)
    {
        var obj = Asset.I.Get<MonoBehaviour>(name);

        if (obj != null)
        {
            return obj.gameObject;
        }

        return CreateNewEntity(prefab, Resources.Load<TextAsset>("Entities/" + name));
    }

    /**
     * 
     */
    GameObject CreateNewEntity(GameObject prefab, TextAsset json)
    {
        var entity = Instantiate(prefab, transform);
        entity.name = json.name;

        AddComponents(entity, JsonUtility.FromJson<JsonObject>(json.text).components);
        entity.GetComponent<MonoBehaviour>().DataSync(json.text);

        return entity;
    }

    /**
     * 
     */
    void DeletePrefabs()
    {
        foreach (Transform child in Asset.I.transform)
            if (child.name.Contains("+") == false)
            {
                Destroy(child.gameObject);
            }
    }

    /**
     * 
     */
    void RenamePrefabs()
    {
        foreach (Transform child in Asset.I.transform)
        {
            child.name = child.name.Split('.')[^1].Replace("+", "");
        }
    }

    /**
     * 
     */
    void InvokePrefabs()
    {
        foreach (Transform child in Asset.I.transform)
        {
            //child.gameObject.SetActive(true);
            child.SendMessage("OnPrefabCreated", SendMessageOptions.DontRequireReceiver); //Change to InvokePrefabCreated
            child.gameObject.SetActive(false);
        }
    }

    /**
     * 
     */
    void AddComponents(GameObject go, string[] components)
    {
        if (components != null)
            foreach (var c in components)
            {
                AddComponentFromType(go, c.ToString());
            }
    }

    /**
     * 
     */
    //void JsonOverwrite(GameObject go, string json)
    //{
    //    foreach (var c in go.GetComponents<IComponent>())
    //    {
    //        JsonUtility.FromJsonOverwrite(json, c);
    //    }
    //}

    /**
     * 
     */
    void AddComponentFromType(GameObject go, string type)
    {
        var t = TypeFromString(type);

        if (t != null)
        {
            go.AddComponent(t);
        }
    }

    /**
     * 
     */
    Type TypeFromString(string type)
    {
        foreach (var item in AppDomain.CurrentDomain.GetAssemblies())
        {
            Type t = Type.GetType(type + ", " + item.FullName);

            if (t != null)
            {
                return t;
            }
        }

        return null;
    }
}