using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Vector3 newPosition;
    public Camera gameCamera;
    public SpriteRenderer chaserRenderer;
    public float speed;
    Vector3 lastClickedPosition = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello world");
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 mousePositionInWorldSpace = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePositionInWorldSpace.z = 0f;

        if (Input.GetMouseButtonDown(0))
        {
            lastClickedPosition = mousePositionInWorldSpace;
        }

        Vector3 start = transform.position;
        Vector3 target = lastClickedPosition;
        Vector3 directionToMove = target - start;

        transform.position = transform.position + directionToMove * speed;

        Vector3 screenSpacePosition = gameCamera.WorldToScreenPoint(transform.position);
        //Debug.Log("screenSpacePosition = " + screenSpacePosition.ToString());

        float xMin = 0f;
        float yMin = 0f;
        float xMax = Screen.width;
        float yMax = Screen.height;

        // if chaser's value is less than xMin, greater than xMax, less than yMin, or greater than yMax,
        // THEN:
        // change colour of sprite to red

        bool xMaxExceeded = screenSpacePosition.x >= (xMax - 50);
        bool xMinExceeded = screenSpacePosition.x <= (xMin + 50);
        bool yMaxExceeded = screenSpacePosition.y >= (yMax - 50);
        bool yMinExceeded = screenSpacePosition.y <= (yMin + 50);

        //Debug.Log("xMaxExceeded = " + xMaxExceeded.ToString());
        //Debug.Log("xMinExceeded = " + xMinExceeded.ToString());
        //Debug.Log("yMaxExceeded = " + yMaxExceeded.ToString());
        //Debug.Log("yMinExceeded = " + yMinExceeded.ToString());

        if (xMaxExceeded && yMaxExceeded || xMinExceeded && yMinExceeded)
        {
            chaserRenderer.color = Color.green;
        }
        else if (xMaxExceeded || xMinExceeded || yMaxExceeded || yMinExceeded)
        {
            chaserRenderer.color = Color.red;
        }
        else
        {
            chaserRenderer.color = Color.white;
        }

    }
}
