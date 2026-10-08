using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1, 0, 0);
    public float speed = 2.0f;
    public bool worldSpace = false;

    void Update()
    {
        if (worldSpace)
        {
            transform.Translate(moveDirection * speed, Space.World);
        }
        else
        {
            transform.Translate(moveDirection * speed, Space.Self);
        }
    }
}