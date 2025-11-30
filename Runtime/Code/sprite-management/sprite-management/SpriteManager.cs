/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;
using UnityEngine.U2D;

/**
 * 
 */
public class SpriteManager : Singleton<SpriteManager>
{
    [SerializeField] SpriteAtlas atlas;    //
    [SerializeField] Sprite      untitled; //

    /**
	 * 
	 */
    public Sprite Get(string k) { if (atlas == null) { atlas = Resources.Load<SpriteAtlas>("Sprites/sprite-atlas"); } Sprite sprite = atlas.GetSprite(k); return sprite != null ? sprite : untitled; }
}
