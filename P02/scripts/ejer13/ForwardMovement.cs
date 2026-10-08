using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    public float speed = 3.0f;
    public float rotationSpeed = 90.0f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        // Girar sobre el eje Y
        transform.Rotate(
            0,
            horizontal * rotationSpeed * Time.deltaTime,
            0
        );

        // Avanzar siempre hacia el eje Z positivo local
        transform.position +=
            transform.forward * speed * Time.deltaTime;
    }
}