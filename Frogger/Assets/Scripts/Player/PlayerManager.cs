using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    ScoreManager manager;
    GameObject player;
    public GameObject enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collisor)
    {
        if (collisor.gameObject.tag == "End")
        {
            manager.score += 1;
            enemy.GetComponent<EnemyMovement>().speed += 0.3f;
            player.transform.position = new Vector3(0, -4);
        }
        if(collisor.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            gameOverScreen.SetActive(true);
        }
    }
}
