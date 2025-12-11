/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using System.Collections.Generic;
using UnityEngine;

/**
 * 
 */
public abstract class Selection
{
    /**
	 * 
	 */
    public abstract void Calculate(ref List<Vector2Int> nodes, int s_x, int s_y, int e_x, int e_y);
}