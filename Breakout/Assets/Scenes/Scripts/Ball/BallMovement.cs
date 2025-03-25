using System;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public GameObject gameOverScreen;
    PlayerMovement playerMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector3(0, -5.0f, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector3(
                collision.gameObject.GetComponent<Rigidbody2D>().linearVelocityX + gameObject.GetComponent<Rigidbody2D>().linearVelocityX,
                -gameObject.GetComponent<Rigidbody2D>().linearVelocityY, 0);
        }
        else if (collision.gameObject.tag == "Top Wall")
        {
            gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector3(
                gameObject.GetComponent<Rigidbody2D>().linearVelocityX,
                -gameObject.GetComponent<Rigidbody2D>().linearVelocityY, 0);
        }
        else if (collision.gameObject.tag == "Wall")
        {
            gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector3(
                -gameObject.GetComponent<Rigidbody2D>().linearVelocityX,
                gameObject.GetComponent<Rigidbody2D>().linearVelocityY, 0);
        }
        else if (collision.gameObject.tag == "Ground") {
            playerMovement.UnableControlls();
            Destroy(gameObject);
            gameOverScreen.SetActive(true);
        }
    }

}
