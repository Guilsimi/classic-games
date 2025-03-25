using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public GameObject enemy;
    float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Cooldown();
    }

    void Spawn()
    {
        int carPosition = Random.Range(-3, 3);
        if (carPosition == -3 || carPosition == -1 || carPosition == 1)
        {
            Instantiate(enemy, new Vector3(-10, carPosition, 0), Quaternion.identity);
        }
        if (carPosition == -2 || carPosition == -0 || carPosition == 2)
        {
            Instantiate(enemy, new Vector3(10, carPosition, 0), Quaternion.identity);
        }
    }

    void Cooldown()
    {
        if (timer <= 0)
        {
            Spawn();
            timer = 1;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
