using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class CodingGymLerp : MonoBehaviour
{
    [Range(0f, 1f)] public float t;

    public Transform[] waypoints;

    public bool forward = true;

    public AnimationCurve curve;

    public int marker;
    int markerMod;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        markerMod = marker % 3;
        if (forward == true)
        {
            t += 0.0008f;
        } else
        {
            t -= 0.0008f;
        }
        transform.position = Vector2.Lerp(waypoints[markerMod].position, waypoints[markerMod+1].position, curve.Evaluate(t));
        if (t <= 0)
        {
            forward = true;
        }
        if (t >= 1)
        {
            t = 0;
            marker += 1;
        }
        if (marker == 2)
        {
            marker = 0;
        }
    }
}
