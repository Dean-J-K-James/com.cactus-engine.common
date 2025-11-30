/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/


using UnityEngine;

/**
 * 
 */
public abstract class TileTM : TileTMBase
{
    public int x; //
    public int y; //
    public int z; //

    /**
     * 
     */
    void OnCreated() { TileManager.I.Set(x, y, z, this); }
    void OnChanged() { TileManager.I.Set(x, y, z, this); }
    void OnDeleted() { TileManager.I.Set(x, y, z, null); }
}
