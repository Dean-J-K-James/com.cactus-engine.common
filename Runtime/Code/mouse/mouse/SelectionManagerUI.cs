/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * 
 */
public class SelectionManagerUI : MonoBehaviour //shouldnt be called ui because it doesnt use the ui canvas system.
{
    public Tilemap tilemap; //
    public TileBase preview; //

    /**
	 * 
	 */
    void OnMouseMPost()
    {
        tilemap.ClearAllTiles();

        foreach (var node in SelectionManager.I.nodes)
        {
            tilemap.SetTile(new Vector3Int(node.x, node.y, 0), preview);
        }
    }

    void OnMouseUPost()
    {
        tilemap.ClearAllTiles();

        foreach (var node in SelectionManager.I.nodes)
        {
            tilemap.SetTile(new Vector3Int(node.x, node.y, 0), preview);
        }
    }
}

//have the mouse preview set up using the same functionality as when we followed project porcupine from quill18.
//have boxselection, fillselection, lineselection, singleselection...