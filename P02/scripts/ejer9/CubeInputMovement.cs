using UnityEngine;

public class CubeInputMovement : MonoBehaviour
{
    public float speed = 0.1f;

    void Update()
    {
        Vector3 movimiento = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
            movimiento += Vector3.forward;

        if (Input.GetKey(KeyCode.DownArrow))
            movimiento += Vector3.back;

        if (Input.GetKey(KeyCode.LeftArrow))
            movimiento += Vector3.left;

        if (Input.GetKey(KeyCode.RightArrow))
            movimiento += Vector3.right;

        transform.Translate(movimiento * speed * Time.deltaTime, Space.World);
    }
}