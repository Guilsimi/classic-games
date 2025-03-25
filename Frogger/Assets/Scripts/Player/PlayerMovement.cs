using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement() {
        if(Input.GetKeyDown(KeyCode.D)) {
            gameObject.transform.position += new Vector3(1f, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.A)) {
            gameObject.transform.position += new Vector3(-1f, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.W)) {
            gameObject.transform.position += new Vector3(0, 1f, 0);
        }
        if(Input.GetKeyDown(KeyCode.S)) {
            gameObject.transform.position += new Vector3(0, -1f, 0);
        }
    }

}
