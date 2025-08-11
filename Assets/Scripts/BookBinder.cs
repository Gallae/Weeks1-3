using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookBinder : MonoBehaviour
{
    private float moveTimer = 5;
    private float resetTimer = 1;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveTimer > 0)
        {
            moveTimer -= Time.deltaTime;
        }
        if (moveTimer <= 0 && transform.position.y > -4.69)
        {  
            moveTimer = 0;
            Vector3 newPos = transform.position + Vector3.down * moveSpeed * Time.deltaTime;
            transform.position = newPos;
        }
        if (transform.position.y <= -4.69)
        {
            resetTimer -= Time.deltaTime;
        }
        if (resetTimer <= 0 && transform.position.y < -2.07)
        { 
            resetTimer = 0;
            Vector3 newPos = transform.position + Vector3.up * (moveSpeed / 3) * Time.deltaTime;
            transform.position = newPos;
        }
    }
}
