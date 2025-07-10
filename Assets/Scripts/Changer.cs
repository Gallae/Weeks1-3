using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Changer : MonoBehaviour
{
    private float timeSinceStart = 0;
    private float bigScale = 2;
    
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceStart += Time.deltaTime;

        if (timeSinceStart >= 3)
        {
            sr.color = Color.green;
        }
        if (timeSinceStart >= 4)
        {
            transform.localScale = Vector3.one*bigScale;
        }
        //if (timeSinceStart >= 5)
        //{
        //    transform.rotation.z = 
        //}
    }
}
