/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class Mouse : Singleton<Mouse>
{
    public Vector2Int position; //
    public Vector2Int down; //

    /**
	 * 
	 */
    void Update()
    {
        Vector3 mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        var temp_x = Mathf.RoundToInt(mouse_pos.x);
        var temp_y = Mathf.RoundToInt(mouse_pos.y);

        down.x = Input.GetKey(KeyCode.Mouse0) ? down.x : temp_x;
        down.y = Input.GetKey(KeyCode.Mouse0) ? down.y : temp_y;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            this.InvokeGlobalMouseD();
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            this.InvokeGlobalMouseU();
        }

        if (temp_x != position.x || temp_y != position.y)
        {
            position.x = temp_x;
            position.y = temp_y;

            this.InvokeGlobalMouseM();
        }
    }
}