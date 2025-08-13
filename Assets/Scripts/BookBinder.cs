using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookBinder : MonoBehaviour
{
    private float moveTimer = 9;
    private float resetTimer = 1;
    public float moveSpeed;
    private bool atBottomOfTravel = false;
    private bool bookBound = false;
    public GameObject boundBook;


    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (moveTimer > 0)
            {
                moveTimer -= Time.deltaTime;
            }
            //after a timer, binder stamps down on the stack of pages
            if (moveTimer <= 0 && transform.position.y >= -0.43 && !atBottomOfTravel)
            {
                moveTimer = 0;
                Vector3 newPos = transform.position + Vector3.down * moveSpeed * Time.deltaTime;
                transform.position = newPos;
            }

            //boolean so code knows when the binder needs to raise back up
            if (transform.position.y <= -0.43)
            {
                resetTimer -= Time.deltaTime;
                atBottomOfTravel = true;
            }
            //binder raises back up
            if (resetTimer <= 0 && transform.position.y <= 2.26)
            {
                resetTimer = 0;
                Vector3 newPos = transform.position + Vector3.up * (moveSpeed / 3) * Time.deltaTime;
                transform.position = newPos;
                bookBound = true;
            }
            // book prefab naturally has a scale of 0,0,0 which is set to 1.33 on all sides when
            // bookBound is true
            if (bookBound)
            {
                boundBook.transform.localScale = new Vector3(1.33f, 1.33f, 1.33f);
            }
        }
    }
}
