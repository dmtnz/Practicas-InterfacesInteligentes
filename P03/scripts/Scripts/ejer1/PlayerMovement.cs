using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;

    private Rigidbody rb;
    private Vector3 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        movement = new Vector3(horizontal, 0.0f, vertical);

        if (movement.magnitude > 1.0f)
        {
            movement = movement.normalized;
        }
    }

    void FixedUpdate()
    {
        Vector3 nuevaPosicion =
            rb.position + movement * speed * Time.fixedDeltaTime;

        rb.MovePosition(nuevaPosicion);
    }
}