using UnityEngine;

public abstract class Building : MonoBehaviour
{
    protected static float constructionTime;
    protected static WaitForSeconds wait = new WaitForSeconds(constructionTime);

    public static WaitForSeconds GetWait()
    {
        return wait;
    }
}