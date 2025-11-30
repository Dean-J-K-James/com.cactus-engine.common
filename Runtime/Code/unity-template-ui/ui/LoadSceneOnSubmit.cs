/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class LoadSceneOnSubmit : MonoBehaviour
{
	public string scene; //

	/**
	 * 
	 */
	void OnButtonSubmit() => UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
}
