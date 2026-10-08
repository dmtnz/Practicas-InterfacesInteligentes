using UnityEngine;

public class MoveToPosition : MonoBehaviour
{
    public Vector3 desplazamiento;

    private Vector3 posicionInicial;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        float salto = Input.GetAxis("Jump");

        if (salto > 0)
        {
            transform.position = posicionInicial + desplazamiento;
        }
    }
}