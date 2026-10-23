using UnityEngine;

public class EsferaPerseguidora : MonoBehaviour
{
    public CilindroAviso cilindroAviso;
    public Transform metaTipo1;
    public float rapidez = 3.0f;
    public float margenLlegada = 1.0f;

    private Transform objetivoActual;

    void Start()
    {
        if (CompareTag("Tipo1"))
        {
            cilindroAviso.AlImpactarCubo += IrAMeta;
        }
        else if (CompareTag("Tipo2"))
        {
            cilindroAviso.AlImpactarCubo += IrACilindro;
        }
    }

    void Update()
    {
        Vector3 vectorHacia = objetivoActual.position - transform.position;
        if (vectorHacia.magnitude > margenLlegada)
        {
            transform.Translate(Time.deltaTime * rapidez * vectorHacia.normalized, Space.World);
        }
    }

    void IrAMeta()
    {
        objetivoActual = metaTipo1;
    }

    void IrACilindro()
    {
        objetivoActual = cilindroAviso.transform;
    }
}
