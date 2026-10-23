using UnityEngine;

public class ZonaDeteccion : MonoBehaviour
{
    public delegate void Aviso();
    public static event Aviso AlEntrarCubo;

    void OnTriggerEnter(Collider otro)
    {
        if (otro.CompareTag("Cubo"))
        {
            AlEntrarCubo?.Invoke();
        }
    }
}
