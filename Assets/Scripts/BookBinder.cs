using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookBinder : MonoBehaviour
{
    private float moveTimer = 9;
    private float resetTimer = 1;
    public float moveSpeed;
    private bool atBottomOfTravel = false;

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
        if (moveTimer <= 0 && transform.position.y >= -0.43 && !atBottomOfTravel)
        {  
            moveTimer = 0;
            Vector3 newPos = transform.position + Vector3.down * moveSpeed * Time.deltaTime;
            transform.position = newPos;
        }
        if (transform.position.y <= -0.43)
        {
            resetTimer -= Time.deltaTime;
            atBottomOfTravel = true;
        }
        if (resetTimer <= 0 && transform.position.y <= 2.26)
        { 
            resetTimer = 0;
            Vector3 newPos = transform.position + Vector3.up * (moveSpeed / 3) * Time.deltaTime;
            transform.position = newPos;
        }
    }
}
