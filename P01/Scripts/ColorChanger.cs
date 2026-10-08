using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public int framesEspera = 120;

    private Vector3 color;
    private int contadorFrames = 0;
    private Renderer objetoRenderer;

    void Start()
    {
        color = new Vector3(
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f)
        );

        objetoRenderer = GetComponent<Renderer>();

        objetoRenderer.material.color =
            new Color(color.x, color.y, color.z);
    }

    void Update()
    {
        contadorFrames++;

        if (contadorFrames >= framesEspera)
        {
            int posicion = Random.Range(0, 3);
            float nuevoValor = Random.Range(0.0f, 1.0f);

            if (posicion == 0)
                color.x = nuevoValor;
            else if (posicion == 1)
                color.y = nuevoValor;
            else
                color.z = nuevoValor;

            objetoRenderer.material.color =
                new Color(color.x, color.y, color.z);

            contadorFrames = 0;
        }
    }
}