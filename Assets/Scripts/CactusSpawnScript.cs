using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpawnScript : MonoBehaviour
{
    public GameObject Cactus;
    public float minSpawnRate = 0.5f;
    public float maxSpawnRate = 2.5f;
    private float spawnRate;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = Random.Range(minSpawnRate, maxSpawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }

        else
        {
            Instantiate(Cactus, transform.position, transform.rotation);
            timer = 0;
            spawnRate = Random.Range(minSpawnRate, maxSpawnRate);
        }
    }
}
