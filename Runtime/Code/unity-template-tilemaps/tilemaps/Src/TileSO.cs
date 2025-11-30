/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * 
 */
public class TileSO : TileBase
{
    /**
     * 
     */
    public override void GetTileData(Vector3Int p, ITilemap t, ref TileData d) { base.GetTileData(p, t, ref d); var tile = TileManager.I.Get(p.x, p.y, p.z); if (tile != null) tile.GetTileData(ref d); }
}
