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
    //have the attributes string array here.
    //when connecting joined tiles, have a variable, connectedAttribute that is used to connect to other tiles with the same attribute in their attributes array.

    /**
     * 
     */
    public abstract void GetTileData(ref TileData d); //Make this virtual and set the collider based on if walkable is set.
}
