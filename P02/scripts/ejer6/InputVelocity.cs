using UnityEngine;

public class InputVelocity : MonoBehaviour
{
    public float velocidad = 5.0f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Flecha arriba: " + velocidad * vertical);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Flecha abajo: " + velocidad * vertical);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Flecha derecha: " + velocidad * horizontal);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Flecha izquierda: " + velocidad * horizontal);
        }
    }
}