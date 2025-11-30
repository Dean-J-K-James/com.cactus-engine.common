/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using System.Collections.Generic;
using UnityEngine;

/**
 * 
 */
public class TileManager : Singleton<TileManager>
{
    Dictionary<Vector3Int, TileTMBase> tilesDictionary = new(); //

    /**
	 * 
	 */
    public TileTMBase Set(int x, int y, int z, TileTMBase t = null) { var p = new Vector3Int(x, y, z); tilesDictionary[p] = t; GetComponent<TileSOManager>().Change(p, t); return t; }
    public TileTMBase Get(int x, int y, int z, TileTMBase d = null) { var p = new Vector3Int(x, y, z); if (tilesDictionary.ContainsKey(p)) return tilesDictionary[p]; else return d; }
}