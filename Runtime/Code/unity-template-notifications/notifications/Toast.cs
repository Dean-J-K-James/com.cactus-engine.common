/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class Toast : Singleton<Toast>
{
    public StringUI toast; //

    /**
	 * 
	 */
    public void Create(string message)
    {
        var go = Instantiate(toast, transform);
        go.Change(message);
        Destroy(go.gameObject, 2.5f);
        //toast.text = message;
    }
}
