/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * 
 */
public abstract class TileTMBase : MonoBehaviour, IComponent
{
    //Perhaps have a bool here for if there should be a collider.

    /**
     * 
     */
    public abstract void GetTileData(ref TileData d); //Make this virtual and use the collider bool.
}
