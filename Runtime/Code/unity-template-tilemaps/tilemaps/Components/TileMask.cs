/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class TileMask : MonoBehaviour, IComponent
{
    public MaskInfo mask;   //
    public string   sprite; //
    public int      x;      //
    public int      y;      //
    public int      z;      //

    /**
	 * 
	 */
    void OnChangedPre()
    {
        var m = 0;

        var NN = TilesConnected.Check(new Vector3Int(x, y, z), new Vector3Int(x + 0, y + 1, z + 0));
        var NE = TilesConnected.Check(new Vector3Int(x, y, z), new Vector3Int(x + 1, y + 1, z + 0));
        var EE = TilesConnected.Check(new Vector3Int(x, y, z), new Vector3Int(x + 1, y + 0, z + 0));
        var SE = TilesConnected.Check(new Vector3Int(x, y, z), new Vector3Int(x + 1, y - 1, z + 0));
        var SS = TilesConnected.Check(new Vector3Int(x, y, z), new Vector3Int(x + 0, y - 1, z + 0));
        var SW = TilesConnected.Check(new Vector3Int(x, y, z), new Vector3Int(x - 1, y - 1, z + 0));
        var WW = TilesConnected.Check(new Vector3Int(x, y, z), new Vector3Int(x - 1, y + 0, z + 0));
        var NW = TilesConnected.Check(new Vector3Int(x, y, z), new Vector3Int(x - 1, y + 1, z + 0));

        if (!(NN && EE)) { NE = false; }
        if (!(NN && WW)) { NW = false; }
        if (!(SS && EE)) { SE = false; }
        if (!(SS && WW)) { SW = false; }

        if (NN) { m += 001; }
        if (NE) { m += 002; }
        if (EE) { m += 004; }
        if (SE) { m += 008; }
        if (SS) { m += 016; }
        if (SW) { m += 032; }
        if (WW) { m += 064; }
        if (NW) { m += 128; }

        mask = MaskInfoManager.masks[m];

        this.DataSync();
    }
}
