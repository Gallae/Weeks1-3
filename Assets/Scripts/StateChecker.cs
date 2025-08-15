using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChecker : MonoBehaviour
{
    //this code is meant to check the x value of the pages when spacebar is pressed but I can't move this script
    //onto anything in the inspector and I don't know why
    void CheckState()
    {
        if (transform.parent != null)
        {
            if (transform.position.x < 0.26f ||  transform.position.x < 3)
            {
                print("You missed the pages entirely! You're fired!");
            }
            else if (transform.position.x < 0.91f || transform.position.x < 2.25f)
            {
                print("This is alright, but the cover is on backwards.");
            }
            else
            {
                print("Good job!");
            }
        }
    }
}
