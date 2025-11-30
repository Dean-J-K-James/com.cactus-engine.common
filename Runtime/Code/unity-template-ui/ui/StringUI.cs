/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using TMPro;
using UnityEngine;

/**
 * 
 */
public class StringUI : MonoBehaviour
{
	public TextMeshProUGUI text; //

	/**
     * 
     */
	public void Change(object val) { text.text = val.ToString(); }
}
