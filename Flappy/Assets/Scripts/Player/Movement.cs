using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public GameObject gameOverScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    void Jump() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            gameObject.GetComponent<Rigidbody2D>().linearVelocityY = speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collisor) {
        if(collisor.gameObject.tag == "Wall") {
            this.enabled = false;
            gameOverScreen.SetActive(true);
        }
    }
}
