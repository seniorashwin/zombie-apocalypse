using UnityEngine;

public class GameInput : MonoBehaviour
{
    public static Vector2 GetMoveInput()
    {
        float x =  Input.GetAxis("Horizontal");
        float y =  Input.GetAxis("Vertical");
        return new Vector2(x,y).normalized;
    }
}