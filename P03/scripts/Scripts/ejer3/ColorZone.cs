using UnityEngine;

public class ColorZone : MonoBehaviour
{
    public Renderer playerRenderer;

    private Color colorOriginal;

    void Start()
    {
        colorOriginal = playerRenderer.material.color;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerRenderer.material.color = Color.red;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerRenderer.material.color = colorOriginal;
        }
    }
}