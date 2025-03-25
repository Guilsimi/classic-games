using UnityEngine;
using UnityEngine.Rendering;

public class ObstaclesMovement : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, 10);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    void Movement() {
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }
}
