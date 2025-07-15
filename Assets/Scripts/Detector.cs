using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    SpriteRenderer detectorRenderer;
    public float colourChangeDistance;

    // Start is called before the first frame update
    void Start()
    {
        detectorRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 firstPosition = transform.position;
        Vector3 secondPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        secondPosition.z = 0;
        float distanceBetweenPositions = Vector3.Distance(firstPosition, secondPosition);
        if(distanceBetweenPositions < colourChangeDistance)
        {
            detectorRenderer.color = Color.black;
        }
        else
        {
            detectorRenderer.color = Color.white;
        }
        Debug.Log(detectorRenderer.color);
    }
}
