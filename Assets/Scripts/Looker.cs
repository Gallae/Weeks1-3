using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
{
    public Camera gameCamera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 newRotation = transform.eulerAngles + Vector3.forward *1f;
        //transform.eulerAngles = newRotation;

        Vector3 mousePos = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        Vector3 start = transform.position;
        Vector3 end = mousePos;

        Vector3 direction = end - start;

        //set transform.up to face the direction of the mouse
        transform.up = direction;
    }
}
