using UnityEngine;

public class FollowSphere : MonoBehaviour
{
    public Transform sphere;
    public float speed = 3.0f;

    void Update()
    {
        Vector3 direccion = sphere.position - transform.position;

        direccion.y = 0;

        direccion = direccion.normalized;

        transform.Translate(
            direccion * speed * Time.deltaTime,
            Space.World
        );
    }
}