/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class InvokeOnTriggerEnter2D : MonoBehaviour //REMOVE
{
    public Transform parent; //

    /**
	 * 
	 */
    void OnTriggerEnter2D(Collider2D collider) { parent.BroadcastMessage("OnTrigger", collider, SendMessageOptions.DontRequireReceiver); }
}
