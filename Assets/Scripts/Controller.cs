using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Vector3 startValue;
    public Vector3 endValue;

    public float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = Random.Range(0f, 1f);

        Vector3 output = Vector3.Lerp(startValue, endValue, currentTime);

        transform.position = output;

        Debug.Log(output);
    }
}
