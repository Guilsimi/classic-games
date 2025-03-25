using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector3(horizontal * 5.0f, 0, 0);

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            float horizontal = Input.GetAxisRaw("Horizontal");

            gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector3(horizontal * 0, 0, 0);
        }
    }

    public void UnableControlls() {
        Destroy(gameObject.GetComponent<PlayerMovement>());
        gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector3(0, 0, 0);
    }

}
