using UnityEngine;

public class BlockDestruct : MonoBehaviour
{

    private ScoreManager manager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            Destroy(collision.gameObject);
            gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector3(
                gameObject.GetComponent<Rigidbody2D>().linearVelocityX,
                -gameObject.GetComponent<Rigidbody2D>().linearVelocityY, 0);
            manager.point += 1;
        }
    }
}
