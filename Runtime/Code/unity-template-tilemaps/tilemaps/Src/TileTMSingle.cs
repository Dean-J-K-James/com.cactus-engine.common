/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using System.Linq;
using UnityEngine.Tilemaps;

/**
 * 
 */
public class TileTMSingle : TileTM
{
    public string   sprite;     //
    public string[] attributes; //put this in TileTMBase and default to false. less walls than paths so default should be false.

    /**
     * 
     */
    public override void GetTileData(ref TileData d) { d.sprite = SpriteManager.I.Get(sprite); d.colliderType = attributes.Contains("walkable") ? Tile.ColliderType.None : Tile.ColliderType.Grid; }
}
