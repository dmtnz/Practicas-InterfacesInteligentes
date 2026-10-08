using UnityEngine;
using TMPro;

public class ShowPosition : MonoBehaviour
{
    private Transform sphereTransform;
    public TMP_Text positionText;

    void Start()
    {
        sphereTransform = GetComponent<Transform>();
    }

    void Update()
    {
        positionText.text = "Posición de la esfera: " + sphereTransform.position;
    }
}