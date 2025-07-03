using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMover : MonoBehaviour
{

    public float speed = 1;
    float xMax = 8.38f;
    float xMin = -8.38f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position + Vector3.right * (speed*Time.deltaTime);
        transform.position = newPosition;
        if(newPosition.x >= xMax)
        {
            speed *= -1;
        }
        if(newPosition.x <= xMin)
        {
            speed = Mathf.Abs(speed);
        }
    }
}

// Resources used:
// https://discussions.unity.com/t/how-can-i-get-the-x-position-for-the-left-and-right-of-the-screen/145849
// https://www.reddit.com/r/Unity3D/comments/eatx3z/help_how_to_detect_if_a_game_object_is_to_the/
// https://discussions.unity.com/t/converting-negative-float-value-to-positive-value/43719
