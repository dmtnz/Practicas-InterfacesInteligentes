using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class MovimientoJugador : MonoBehaviour
{
    public float rapidez = 5.0f;
    Rigidbody cuerpo;
    Vector3 entrada;

    void Start()
    {
        cuerpo = GetComponent<Rigidbody>();
    }

    void Update()
    {
        entrada = new(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        cuerpo.MovePosition(cuerpo.position + rapidez * Time.fixedDeltaTime * entrada);
        if (entrada != Vector3.zero)
        {
            cuerpo.MoveRotation(Quaternion.LookRotation(entrada));
        }
    }
}
