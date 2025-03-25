using Unity.Mathematics;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (gameObject.transform.position == new Vector3(10, transform.position.y)) {
            speed = -speed;
        }
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        gameObject.transform.position += new Vector3(speed * Time.deltaTime, 0);
    }
}
