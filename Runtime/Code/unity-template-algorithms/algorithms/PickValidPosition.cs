/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using System;
using UnityEngine;

/**
 * 
 */
public static class PickValidPosition
{
	/**
	 * 
	 */
	public static Vector2Int Get(int sx, int sy, int ex, int ey, int attempts, Func<int, int, bool> cb)
	{
        for (int i = 0; i < attempts; i++)
        {
            var x = UnityEngine.Random.Range(sx, ex);
            var y = UnityEngine.Random.Range(sy, ey);

            if (cb(x, y))
            {
                return new Vector2Int(x, y);
            }
        }

        return Vector2Int.zero;
    }
}
