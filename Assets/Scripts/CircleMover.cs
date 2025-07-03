using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMover : MonoBehaviour
{
    
    bool moveRight;
    bool moveUp;
    bool moveDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 circlePos = transform.position;
        moveRight = Input.GetKey(KeyCode.RightArrow);
        moveUp = Input.GetKeyUp(KeyCode.UpArrow);
        moveDown = Input.GetKeyDown(KeyCode.DownArrow);

        if (moveRight)
        {
            circlePos.x += 0.5f;
        }
        if (moveUp)
        {
            circlePos.y += 0.1f;
        }
        if (moveDown)
        {
            circlePos.y -= 0.1f;
        }

        transform.position = circlePos;
    }
}
