using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    public GameObject fireball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject spawnedObject;

            spawnedObject = Instantiate(fireball, transform.position, transform.rotation, transform);

            Transform spawnedTransform = spawnedObject.GetComponent<Transform>();

            spawnedTransform.SetParent(transform);

            spawnedTransform.parent = null;
        }
    }
}
