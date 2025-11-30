/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;
using UnityEngine.UI;

/**
 * 
 */
public class ImageUI : MonoBehaviour
{
    public Image image; //

    /**
     * 
     */
    public void Change(Sprite val) { image.sprite = val; }
}
