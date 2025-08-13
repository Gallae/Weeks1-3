using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private float fallTimer = 6.75f;
    private float moveTimer;
    private float stopTimer;
    Vector3 currentRotation;


    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //actions lined up with movement of other objects in scene
            if (fallTimer >= 0)
            {
                fallTimer -= Time.deltaTime;
            }
            if (fallTimer < 0)
            {
                fallTimer = 0;
                moveTimer = 3;
            }
            if (moveTimer >= 0)
            {
                moveTimer -= Time.deltaTime;
                currentRotation += new Vector3(0, 0, -75) * Time.deltaTime;
                transform.eulerAngles = currentRotation;
                stopTimer = 2;
            }
            if (stopTimer > 0)
            {
                stopTimer -= Time.deltaTime;
            }
            if (stopTimer <= 0)
            {
                stopTimer = 0;
                currentRotation = transform.eulerAngles;
            }
        }

    }
}
