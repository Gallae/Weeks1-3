using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float spawnFrequency;

    private float timeSinceLastSpawn = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        Debug.Log(timeSinceLastSpawn.ToString());
        if (timeSinceLastSpawn > spawnFrequency)
        {
            Instantiate(prefabToSpawn);
            timeSinceLastSpawn = 0;
        }
    }
}
