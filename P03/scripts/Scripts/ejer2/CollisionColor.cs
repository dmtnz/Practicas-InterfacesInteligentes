using UnityEngine;

public class CollisionColor : MonoBehaviour
{
    private Renderer objetoRenderer;

    void Start()
    {
        objetoRenderer = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(
            gameObject.name + " ha colisionado con " +
            collision.gameObject.name
        );

        objetoRenderer.material.color = new Color(
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f)
        );
    }
}