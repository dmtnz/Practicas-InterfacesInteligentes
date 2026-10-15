using UnityEngine;

public class SphereToTarget : MonoBehaviour
{
    public Transform target;
    public Collider obstacle;
    public Material obstacleMaterial;

    public float speed = 3.0f;

    private Collider sphereCollider;
    private Renderer obstacleRenderer;
    private bool obstacleReached = false;

    void Start()
    {
        sphereCollider = GetComponent<Collider>();
        obstacleRenderer = obstacle.GetComponent<Renderer>();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );

        if (!obstacleReached &&
            sphereCollider.bounds.Intersects(obstacle.bounds))
        {
            obstacleRenderer.material = obstacleMaterial;
            obstacleReached = true;
        }
    }
}