/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * 
 */
public class TileSOManager : MonoBehaviour
{
    public Tilemap tilemap; //
    public TileSO  tile;    //

    /**
	 * 
	 */
    public void Change(Vector3Int p, bool notNull) { tilemap.SetTile(p, null); tilemap.SetTile(p, tile); }
}