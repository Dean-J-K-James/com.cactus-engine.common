/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class LoadSceneAfterDelay : MonoBehaviour
{
    public string scene; //
    public float  delay; //

    /**
	 * 
	 */
    void Update() { if ((delay -= Time.deltaTime) <= 0) { UnityEngine.SceneManagement.SceneManager.LoadScene(scene); } }
}
