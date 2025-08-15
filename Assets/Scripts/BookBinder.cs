using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookBinder : MonoBehaviour
{
    private float resetTimer = 1;
    public float moveSpeed;
    private bool atBottomOfTravel = false;
    private bool bookBound = false;
    public GameObject boundBook;

    void Update()
    {
        //after a timer, binder stamps down on the stack of pages
        //turn this into a coroutine
        if (Input.GetKeyDown(KeyCode.Space) && !atBottomOfTravel)
        {
            StartBindBookDown();
        }
    }

    void StartBindBookDown()
    {
        StartCoroutine(BindBookDown());
    }

    public IEnumerator BindBookDown()
    {
        //move Book Binder down
        // IMPORTANT: something I did here is causing the program to crash when you press spacebar now
        while (transform.position.y >= -0.43 && !atBottomOfTravel)
        {
        Vector3 newPos = transform.position + Vector3.down * moveSpeed * Time.deltaTime;
        transform.position = newPos;
        }

        //boolean so code knows when the binder needs to raise back up
        while (transform.position.y <= -0.43)
        {
            resetTimer -= Time.deltaTime;
            atBottomOfTravel = true;
        }
        //run BindBookUp() to raise Book Binder back to original position
        while (resetTimer <= 0 && transform.position.y <= 2.26)
        {
            BindBookUp();
            yield return null;
        }
    }
    void BindBookUp()
    {
        //move Book Binder back to original position and set bookBound to tru
        resetTimer = 0;
        Vector3 newPos = transform.position + Vector3.up * (moveSpeed / 3) * Time.deltaTime;
        transform.position = newPos;
        bookBound = true;

        // once bookBound is true, set the Book prefab to the predetermined scale so it's now visible
        if (bookBound)
        {
            boundBook.transform.localScale = new Vector3(1.33f, 1.33f, 1.33f);
        }
    }
}
