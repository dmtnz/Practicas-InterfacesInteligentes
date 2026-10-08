using UnityEngine;

public class ObjectDistances : MonoBehaviour
{
    public GameObject cube;
    public GameObject cylinder;

    private Transform sphereTransform;
    private Transform cubeTransform;
    private Transform cylinderTransform;

    void Start()
    {
        sphereTransform = GetComponent<Transform>();

        cubeTransform = cube.GetComponent<Transform>();
        cylinderTransform = cylinder.GetComponent<Transform>();

        float distanciaCubo =
            Vector3.Distance(sphereTransform.position, cubeTransform.position);

        float distanciaCilindro =
            Vector3.Distance(sphereTransform.position, cylinderTransform.position);

        Debug.Log("Distancia de la esfera al cubo: " + distanciaCubo);
        Debug.Log("Distancia de la esfera al cilindro: " + distanciaCilindro);
    }
}