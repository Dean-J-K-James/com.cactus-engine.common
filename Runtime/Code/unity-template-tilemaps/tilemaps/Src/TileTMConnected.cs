/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * 
 */
public class TileTMConnected : TileTM
{
    public MaskInfo mask;   //
    public string   sprite; //


    /**
     * 
     */
    public override void GetTileData(ref TileData d) { d.sprite = SpriteManager.I.Get(sprite + "_" + mask.index); d.transform = Matrix4x4.Rotate(Quaternion.Euler(0, 0, mask.rotation)); d.colliderType = Tile.ColliderType.None; }
}