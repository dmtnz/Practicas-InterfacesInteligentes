using UnityEngine;

public class SphereInputMovement : MonoBehaviour
{
    public float speed = 0.1f;

    void Update()
    {
        Vector3 movimiento = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            movimiento += Vector3.forward;

        if (Input.GetKey(KeyCode.S))
            movimiento += Vector3.back;

        if (Input.GetKey(KeyCode.A))
            movimiento += Vector3.left;

        if (Input.GetKey(KeyCode.D))
            movimiento += Vector3.right;

        transform.Translate(movimiento * speed * Time.deltaTime, Space.World);
    }
}