using UnityEngine;

public class LaunchObject : MonoBehaviour
{
    public float force = 5.0f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Vector3 direction = new Vector3(0, 1, 1);

            rb.AddForce(direction * force, ForceMode.Impulse);
        }
    }
}