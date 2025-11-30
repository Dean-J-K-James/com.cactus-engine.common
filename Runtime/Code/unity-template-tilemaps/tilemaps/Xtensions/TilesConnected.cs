/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public static class TilesConnected
{
    /**
	 * 
	 */
    public static bool Check(Vector3Int a, Vector3Int b)
    {
        var ta = TileManager.I.Get(a.x, a.y, a.z);
        var tb = TileManager.I.Get(b.x, b.y, b.z);

        if (ta != null && tb != null)
        {
            var ma = ta.GetComponent<TileMask>();
            var mb = tb.GetComponent<TileMask>();

            if (ma != null && mb != null) { return ma.sprite == mb.sprite; }
        }

        return false;
    }
}
