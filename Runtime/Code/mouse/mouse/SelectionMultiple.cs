/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using System.Collections.Generic;
using UnityEngine;

/**
 * 
 */
public class SelectionMultiple : Selection
{
    /**
	 * 
	 */
    public override void Calculate(ref List<Vector2Int> nodes, int s_x, int s_y, int e_x, int e_y)
    {
        var x1 = Mathf.Min(s_x, e_x);
        var x2 = Mathf.Max(s_x, e_x);
        var y1 = Mathf.Min(s_y, e_y);
        var y2 = Mathf.Max(s_y, e_y);

        for (int x = x1; x <= x2; x++)
            for (int y = y1; y <= y2; y++)
            {
                nodes.Add(new Vector2Int(x, y));
            }
    }
}