using UnityEngine;

public class CilindroAviso : MonoBehaviour
{
    public delegate void AvisoImpacto();
    public event AvisoImpacto AlImpactarCubo;

    void OnCollisionEnter(Collision choque)
    {
        if (choque.gameObject.CompareTag("Cubo"))
        {
            AlImpactarCubo?.Invoke();
        }
    }
}
