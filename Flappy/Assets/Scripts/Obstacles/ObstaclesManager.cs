using UnityEngine;

public class ObstaclesManager : MonoBehaviour
{

    ScoreManager manager;
    float cooldown;
    public GameObject obstacle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Cooldown();
    }

    void Cooldown()
    {
        if (cooldown <= 0)
        {
            Spawn();
            cooldown = 3 - ( manager.score / 10);
        }
        else
        {
            cooldown -= Time.deltaTime;
            Debug.Log(cooldown);
        }
    }

    void Spawn()
    {
        Instantiate(obstacle, new Vector3(5, Random.Range(-3, 3), 0), Quaternion.identity);
    }

}
