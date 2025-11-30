/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public static class ClosestGameObject
{
    /**
	 * 
	 */
    public static GameObject Get(GameObject[] objs, float x, float y)
    {
        GameObject closestObject = null;
        float closestDistance = Mathf.Infinity;

        foreach (GameObject obj in objs)
        {
            float distance = Vector2.Distance(new Vector2(x, y), obj.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestObject = obj;
            }
        }

        return closestObject;
    }
}
