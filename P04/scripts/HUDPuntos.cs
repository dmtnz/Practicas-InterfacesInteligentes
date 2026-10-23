using UnityEngine;
using TMPro;

public class HUDPuntos : MonoBehaviour
{
    public TextMeshProUGUI etiquetaPuntos;
    public TextMeshProUGUI etiquetaPremio;
    public float duracionPremio = 3.0f;
    public string[] premios = { "Espada de madera", "Espada de acero forjada", "Excalibur" };

    void Start()
    {
        RecogedorEscudos.AlCambiarPuntos += RefrescarPuntos;
        RecogedorEscudos.AlConseguirPremio += AnunciarPremio;

        etiquetaPuntos.text = "Puntuación: 0";
        etiquetaPremio.text = "";
    }

    void OnDestroy()
    {
        RecogedorEscudos.AlCambiarPuntos -= RefrescarPuntos;
        RecogedorEscudos.AlConseguirPremio -= AnunciarPremio;
    }

    void RefrescarPuntos(int total)
    {
        etiquetaPuntos.text = "Puntuación: " + total;
    }

    void AnunciarPremio(int indice)
    {
        string premio = premios[(indice - 1) % premios.Length];
        etiquetaPremio.text = "¡Has conseguido " + premio + "!";

        CancelInvoke(nameof(LimpiarPremio));
        Invoke(nameof(LimpiarPremio), duracionPremio);
    }

    void LimpiarPremio()
    {
        etiquetaPremio.text = "";
    }
}
