using UnityEngine;

public abstract class Building : MonoBehaviour
{
    protected static float constructionTime;
    private static WaitForSeconds wait = new WaitForSeconds(constructionTime);

    public static WaitForSeconds GetWait()
    {
        return wait;
    }
}