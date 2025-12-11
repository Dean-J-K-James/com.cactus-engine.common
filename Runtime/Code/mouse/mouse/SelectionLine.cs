/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using System.Collections.Generic;
using UnityEngine;

/**
 * 
 */
public class SelectionLine : Selection
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

        var xd = Mathf.Abs(x1 - x2);
        var yd = Mathf.Abs(y1 - y2);

        if (xd > yd)
        {
            for (int x = x1; x <= x2; x++)
            {
                nodes.Add(new Vector2Int(x, s_y));
            }
        }
        else
        {
            for (int y = y1; y <= y2; y++)
            {
                nodes.Add(new Vector2Int(s_x, y));
            }
        }
    }
}