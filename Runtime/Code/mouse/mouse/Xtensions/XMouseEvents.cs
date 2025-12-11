/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

/**
 * 
 */
public static class XMouseEvents
{
    /**
     * 
     */
    public static void InvokeGlobalMouseD(this Mouse mouse) { InvokeGlobal.Invoke("OnMouseD"); }
    public static void InvokeGlobalMouseM(this Mouse mouse) { InvokeGlobal.Invoke("OnMouseM"); }
    public static void InvokeGlobalMouseU(this Mouse mouse) { InvokeGlobal.Invoke("OnMouseU"); }
}
