using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallScript : MonoBehaviour
{
    private float speed = 1f;
    public float endPos;
    public float fallTimer;
    public float moveTimer;

    // Start is called before the first frame update
    void Start()
    {
        moveTimer = 5 - fallTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (fallTimer > 0) 
        {
            fallTimer -= Time.deltaTime;
        }
        if (fallTimer <= 0 && transform.position.y >= endPos)
        {  
            fallTimer = 0;
            Vector3 newPos = transform.position + Vector3.down * speed * Time.deltaTime;
            transform.position = newPos;
        }
        if (moveTimer > 0 && transform.position.y <= endPos)
        {
            moveTimer -= Time.deltaTime;
        }
        if (moveTimer <= 0 && transform.position.x < 1.5f)
        {  
            moveTimer = 0;
            Vector3 newPosHori = transform.position + Vector3.right * speed * Time.deltaTime;
            transform.position = newPosHori;
        }
    }
}
