using UnityEngine;

public class RecogedorEscudos : MonoBehaviour
{
    public delegate void PuntosActualizados(int total);
    public static event PuntosActualizados AlCambiarPuntos;

    public delegate void PremioConseguido(int indice);
    public static event PremioConseguido AlConseguirPremio;

    public int valorEscudo1 = 5;
    public int valorEscudo2 = 10;
    public int umbralPremio = 100;

    private int puntosTotales = 0;

    void OnCollisionEnter(Collision choque)
    {
        if (choque.gameObject.CompareTag("Escudo1"))
        {
            RecolectarEscudo(choque.gameObject, valorEscudo1);
        }
        else if (choque.gameObject.CompareTag("Escudo2"))
        {
            RecolectarEscudo(choque.gameObject, valorEscudo2);
        }
    }

    void RecolectarEscudo(GameObject objeto, int valor)
    {
        int premiosPrevios = puntosTotales / umbralPremio;

        puntosTotales += valor;
        Destroy(objeto);
        Debug.Log("+" + valor + " puntos! Puntuación: " + puntosTotales);
        AlCambiarPuntos?.Invoke(puntosTotales);

        int premiosActuales = puntosTotales / umbralPremio;
        if (premiosActuales > premiosPrevios)
        {
            AlConseguirPremio?.Invoke(premiosActuales);
        }
    }
}
