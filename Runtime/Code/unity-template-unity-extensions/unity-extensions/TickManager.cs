/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class TickManager : MonoBehaviour
{
    public string message; //
    public float tickLength; //
    private float timer; //

    /**
     * 
     */
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= tickLength)
        {
            timer = 0f;
            //Debug.Log($"TickManager: Tick {message}");
            BroadcastMessage(message, SendMessageOptions.DontRequireReceiver);
        }
    }
}
