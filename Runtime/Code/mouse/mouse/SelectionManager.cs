/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * 
 */
public class SelectionManager : Singleton<SelectionManager>
{
    Selection selection = new SelectionMultiple(); //
    public List<Vector2Int> nodes = new(); //

    /**
	 * 
	 */
    void OnMouseM()
    {
        nodes.Clear();

        selection.Calculate(ref nodes, Mouse.I.down.x, Mouse.I.down.y, Mouse.I.position.x, Mouse.I.position.y);

        SendMessage("OnMouseMPost"); //wont have to call this when the proper events are set up.
    }

    /**
     * 
     */
    void OnMouseU() //The BuildController will run OnMouseU and have the correct selection as generated in OnMouseM. It will be the same so no need to recalculate.
    {
        nodes.Clear();

        selection.Calculate(ref nodes, Mouse.I.position.x, Mouse.I.position.y, Mouse.I.position.x, Mouse.I.position.y);

        SendMessage("OnMouseUPost"); //wont have to call this when the proper events are set up.
    }
}

//have the mouse preview set up using the same functionality as when we followed project porcupine from quill18.
//have boxselection, fillselection, lineselection, singleselection...