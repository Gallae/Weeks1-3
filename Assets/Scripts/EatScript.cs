using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatScript : MonoBehaviour
{

    Vector3 pos;
    public bool isClicked = false;
    float t = 0.5f;

    void Start()
    {
        
    }

    void Update()
    {
        pos = transform.position;
        if (Input.GetMouseButtonDown(0) == true)
        {
            isClicked = true;
        }
        if(isClicked == true)
        {
            pos.z = -0.1f;
            pos.x = -12f;
            t -= Time.deltaTime;
            if (t <= 0)
            {
                isClicked = false;
                t = 0.5f;
            }
        }
        else
        {
            pos.z = -0.1f;
            pos.x = -3.63f;
            Debug.Log("move on");
        }
        transform.position = pos;
    }
}
