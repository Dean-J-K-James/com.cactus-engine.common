/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using System.Collections.Generic;

/**
 * 
 */
public static class MaskInfoManager
{
    /**
     * 
     */
    public static readonly Dictionary<int, MaskInfo> masks = new()
    {
        { 000, new MaskInfo(000, 000, 000, 000) },
        { 001, new MaskInfo(001, 001, 000, 001) },
        { 004, new MaskInfo(004, 001, 270, 001) },
        { 005, new MaskInfo(005, 005, 000, 002) },
        { 007, new MaskInfo(007, 007, 000, 003) },
        { 016, new MaskInfo(016, 001, 180, 001) },
        { 017, new MaskInfo(017, 017, 000, 004) },
        { 020, new MaskInfo(020, 005, 270, 002) },
        { 021, new MaskInfo(021, 021, 000, 005) },
        { 023, new MaskInfo(023, 023, 000, 006) },
        { 028, new MaskInfo(028, 007, 270, 003) },
        { 029, new MaskInfo(029, 029, 000, 007) },
        { 031, new MaskInfo(031, 031, 000, 008) },
        { 064, new MaskInfo(064, 001, 090, 001) },
        { 065, new MaskInfo(065, 005, 090, 002) },
        { 068, new MaskInfo(068, 017, 090, 004) },
        { 069, new MaskInfo(069, 021, 090, 005) },
        { 071, new MaskInfo(071, 029, 090, 007) },
        { 080, new MaskInfo(080, 005, 180, 002) },
        { 081, new MaskInfo(081, 021, 180, 005) },
        { 084, new MaskInfo(084, 021, 270, 005) },
        { 085, new MaskInfo(085, 085, 000, 009) },
        { 087, new MaskInfo(087, 087, 000, 010) },
        { 092, new MaskInfo(092, 023, 270, 006) },
        { 093, new MaskInfo(093, 087, 270, 010) },
        { 095, new MaskInfo(095, 095, 000, 011) },
        { 112, new MaskInfo(112, 007, 180, 003) },
        { 113, new MaskInfo(113, 023, 180, 006) },
        { 116, new MaskInfo(116, 029, 270, 007) },
        { 117, new MaskInfo(117, 087, 180, 010) },
        { 119, new MaskInfo(119, 119, 000, 012) },
        { 124, new MaskInfo(124, 031, 270, 008) },
        { 125, new MaskInfo(125, 095, 270, 011) },
        { 127, new MaskInfo(127, 127, 000, 013) },
        { 193, new MaskInfo(193, 007, 090, 003) },
        { 197, new MaskInfo(197, 023, 090, 006) },
        { 199, new MaskInfo(199, 031, 090, 008) },
        { 209, new MaskInfo(209, 029, 180, 007) },
        { 213, new MaskInfo(213, 087, 090, 010) },
        { 215, new MaskInfo(215, 095, 090, 011) },
        { 221, new MaskInfo(221, 119, 090, 012) },
        { 223, new MaskInfo(223, 127, 090, 013) },
        { 241, new MaskInfo(241, 031, 180, 008) },
        { 245, new MaskInfo(245, 095, 180, 011) },
        { 247, new MaskInfo(247, 127, 180, 013) },
        { 253, new MaskInfo(253, 127, 270, 013) },
        { 255, new MaskInfo(255, 255, 000, 014) },
    };
}
