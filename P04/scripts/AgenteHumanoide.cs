using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AgenteHumanoide : MonoBehaviour
{
    public delegate void Notificacion();
    public static event Notificacion AlChocarCuboConTipo1;
    public static event Notificacion AlChocarCuboConTipo2;

    public Transform escudoAsignado;
    public Transform puntoTeletransporte; // Ej4
    public Transform focoMirada; // Ej4
    public float radioSalto = 1.5f; // Ej4
    public float rapidez = 3.0f;
    public float margenLlegada = 0.1f;
    public Color colorImpacto = Color.yellow;

    private Transform objetivoActual;

    void Start()
    {
        GetComponent<Rigidbody>().isKinematic = true;

        if (CompareTag("Tipo1"))
        {
            AlChocarCuboConTipo2 += IrAEscudoAsignado;
            ZonaDeteccion.AlEntrarCubo += SaltarAEscudo; // Ej4
        }
        else if (CompareTag("Tipo2"))
        {
            AlChocarCuboConTipo1 += IrAEscudoMasCercano;
            ZonaDeteccion.AlEntrarCubo += MirarHaciaFoco; // Ej4
        }
    }

    void OnDestroy()
    {
        AlChocarCuboConTipo2 -= IrAEscudoAsignado;
        AlChocarCuboConTipo1 -= IrAEscudoMasCercano;
        ZonaDeteccion.AlEntrarCubo -= SaltarAEscudo; // Ej4
        ZonaDeteccion.AlEntrarCubo -= MirarHaciaFoco; // Ej4
    }

    void Update()
    {
        if (objetivoActual == null) return;

        Vector3 vectorHacia = objetivoActual.position - transform.position;
        if (vectorHacia.magnitude > margenLlegada)
        {
            transform.Translate(Time.deltaTime * rapidez * vectorHacia.normalized, Space.World);
        }
    }

    void OnCollisionEnter(Collision choque)
    {
        if (choque.gameObject.CompareTag("Cubo"))
        {
            if (CompareTag("Tipo1"))
            {
                AlChocarCuboConTipo1?.Invoke();
            }
            else if (CompareTag("Tipo2"))
            {
                AlChocarCuboConTipo2?.Invoke();
            }
        }
        else if (choque.gameObject.CompareTag("Escudo2"))
        {
            GetComponentInChildren<Renderer>().material.color = colorImpacto;
        }
    }

    void IrAEscudoAsignado()
    {
        objetivoActual = escudoAsignado;
    }

    void IrAEscudoMasCercano()
    {
        float distanciaMinima = Mathf.Infinity;
        foreach (GameObject candidato in GameObject.FindGameObjectsWithTag("Escudo2"))
        {
            float dist = Vector3.Distance(transform.position, candidato.transform.position);
            if (dist < distanciaMinima)
            {
                distanciaMinima = dist;
                objetivoActual = candidato.transform;
            }
        }
    }

    // Ej4
    void SaltarAEscudo()
    {
        objetivoActual = null;
        transform.position = new Vector3(
            puntoTeletransporte.position.x,
            transform.position.y,
            puntoTeletransporte.position.z);
    }

    // Ej4
    void MirarHaciaFoco()
    {
        Vector3 puntoMirada = new(
            focoMirada.position.x,
            transform.position.y,
            focoMirada.position.z);
        transform.LookAt(puntoMirada);
    }
}
