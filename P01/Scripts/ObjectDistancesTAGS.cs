using UnityEngine;

public class ObjectDistancesTags : MonoBehaviour
{
    private GameObject cube;
    private GameObject cylinder;

    void Start()
    {
        cube = GameObject.FindWithTag("cubito");
        cylinder = GameObject.FindWithTag("cilindrito");

        float distanciaCubo = Vector3.Distance(
            transform.position,
            cube.transform.position
        );

        float distanciaCilindro = Vector3.Distance(
            transform.position,
            cylinder.transform.position
        );

        Debug.Log("Distancia de la esfera al cubo: " + distanciaCubo);
        Debug.Log("Distancia de la esfera al cilindro: " + distanciaCilindro);
    }
}