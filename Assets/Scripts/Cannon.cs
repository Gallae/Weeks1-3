using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannonball;
    public float speed;
    public Color cannonballColour;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            GameObject spawnedCannonball = Instantiate(cannonball, transform.position, Quaternion.identity);
            SpriteRenderer cannonballRenderer = spawnedCannonball.GetComponent<SpriteRenderer>();

            Cannonball cannonballScript = spawnedCannonball.GetComponent<Cannonball>();
            cannonballScript.moveDuration = speed;
        }
    }

}
