using UnityEngine;

public class VectorOperations : MonoBehaviour
{
    public Vector3 vector1;
    public Vector3 vector2;

    public float magnitudVector1;
    public float magnitudVector2;
    public float angulo;
    public float distancia;
    public string vectorMasAlto;

    void Start()
    {
        magnitudVector1 = vector1.magnitude;
        magnitudVector2 = vector2.magnitude;

        angulo = Vector3.Angle(vector1, vector2);

        distancia = Vector3.Distance(vector1, vector2);

        if (vector1.y > vector2.y)
        {
            vectorMasAlto = "El vector 1 está a mayor altura";
        }
        else if (vector2.y > vector1.y)
        {
            vectorMasAlto = "El vector 2 está a mayor altura";
        }
        else
        {
            vectorMasAlto = "Los dos vectores están a la misma altura";
        }

        Debug.Log("Magnitud del vector 1: " + magnitudVector1);
        Debug.Log("Magnitud del vector 2: " + magnitudVector2);
        Debug.Log("Ángulo entre los vectores: " + angulo);
        Debug.Log("Distancia entre los vectores: " + distancia);
        Debug.Log(vectorMasAlto);
    }
}