/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class RefreshNeighbours : MonoBehaviour, IComponent
{
    public int x; //
    public int y; //
    public int z; //
    
    /**
     * 
     */
    void OnCreatedPost()
    {
        TileTMBase n = null;

        if (n = TileManager.I.Get(x + 0, y + 1, z)) { n.InvokeChanged(); }
        if (n = TileManager.I.Get(x + 1, y + 1, z)) { n.InvokeChanged(); }
        if (n = TileManager.I.Get(x + 1, y + 0, z)) { n.InvokeChanged(); }
        if (n = TileManager.I.Get(x + 1, y - 1, z)) { n.InvokeChanged(); }
        if (n = TileManager.I.Get(x + 0, y - 1, z)) { n.InvokeChanged(); }
        if (n = TileManager.I.Get(x - 1, y - 1, z)) { n.InvokeChanged(); }
        if (n = TileManager.I.Get(x - 1, y + 0, z)) { n.InvokeChanged(); }
        if (n = TileManager.I.Get(x - 1, y + 1, z)) { n.InvokeChanged(); }
    }
}
