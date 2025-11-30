/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using System;

/**
 * 
 */
[Serializable]
public struct MaskInfo
{
    public int mask;          //
    public int canonicalMask; //
    public int rotation;      //
    public int index;         //

    /**
     * 
     */
    public MaskInfo(int mask, int canonicalMask, int rotation, int index) { this.mask = mask; this.canonicalMask = canonicalMask; this.rotation = rotation; this.index = index; }
}
