using UnityEngine;

public class FollowSphereLookAt : MonoBehaviour
{
    public Transform sphere;
    public float speed = 3.0f;

    void Update()
    {
        Vector3 direccion = sphere.position - transform.position;

        direccion.y = 0;

        if (direccion.magnitude > 0.01f)
        {
            direccion = direccion.normalized;

            transform.LookAt(sphere);

            transform.Translate(
                direccion * speed * Time.deltaTime,
                Space.World
            );
        }
    }
}