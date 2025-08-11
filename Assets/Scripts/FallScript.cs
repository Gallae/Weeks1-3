using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallScript : MonoBehaviour
{
    private float speed = 2f;
    public float endPos;
    public float fallTimer;
    public float moveTimer;
    private float killTimer = 1.5f;

    void Start()
    {
        //timer determining when pages will move to the right on the conveyor belt,
        //offset by the time it takes them to fall into position from off screen.
        moveTimer = 3.01f - fallTimer;
    }

    void Update()
    {
        //fallTimer will tick down each frame until it reaches 0
        if (fallTimer > 0) 
        {
            fallTimer -= Time.deltaTime;
        }

        //once the fallTimer reaches 0, each page will fall until their y reaches endPos,
        //a public variable declared in editor to ensure the pages are properly offset
        //when stacked on top of one another.
        if (fallTimer <= 0 && transform.position.y >= endPos)
        {  
            fallTimer = 0;
            Vector3 newPos = transform.position + Vector3.down * speed * Time.deltaTime;
            transform.position = newPos;
        }

        //once all of the pages reach their endPos, there is a short delay before the
        //pages move along the conveyor belt to the right.
        if (moveTimer > 0 && transform.position.y <= endPos)
        {
            moveTimer -= Time.deltaTime;
        }
        
        //pages move to the right until they reach the spot under the book binder
        if (moveTimer <= 0 && transform.position.x < 1.5f)
        {  
            moveTimer = 0;
            Vector3 newPosHori = transform.position + Vector3.right * speed * 2 * Time.deltaTime;
            transform.position = newPosHori;
        }
        if (transform.position.x >= 1.5f)
        {
            killTimer -= Time.deltaTime;
        }
        if (killTimer <= 0)
        {
            killTimer = 0;
            Destroy(gameObject);
        }
    }
}
