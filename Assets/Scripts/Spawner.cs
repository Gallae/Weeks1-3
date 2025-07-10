using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    List<GameObject> spawnedObjects = new List<GameObject>();
    public GameObject prefabToSpawn;
    public Vector3 spawnPoint;
    public int frameRate;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = frameRate;

        //GameObject object1 = Instantiate(prefabToSpawn);
        //spawnedObjects.Add(object1);
        //GameObject object2 = Instantiate(prefabToSpawn, spawnPoint, Quaternion.identity);
        //spawnedObjects.Add(object2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && spawnedObjects.Count < 5){
            spawnedObjects.Add(Instantiate(prefabToSpawn));
        }
        if (Input.GetMouseButtonDown(1))
        {
            for (int i = 0; i < spawnedObjects.Count; i++)
            {
                Destroy(spawnedObjects[i], (i*0.1f));
            }
            spawnedObjects.Clear();
        }
    }
}
