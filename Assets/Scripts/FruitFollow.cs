using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitFollow : MonoBehaviour
{

    private Vector2 pos;
    public float speed = 0.1f;
    public float eatRange = -2f;
    public float respawnRange = 1f;
    public bool fruitEaten = false;
    public AnimationCurve curve;

    [Range(0, 1)] public float t;
    
    void Start()
    {
        
    }

    void Update()
    {
        pos = Input.mousePosition;
        pos = Camera.main.ScreenToWorldPoint(pos);
        transform.position = pos;

        if(pos.x<= eatRange && fruitEaten == false && Input.GetMouseButtonDown(0) == true)
        {
            transform.localScale = Vector2.zero;
            t = 0;
            fruitEaten=true;
        }

        if(pos.x>= respawnRange && fruitEaten == true)
        {
            transform.localScale = Vector2.Lerp(Vector2.zero, Vector2.one, curve.Evaluate(t));
            t+=Time.deltaTime;
            if (t >= 1)
            {
                fruitEaten = false;
            }
        }

    }
}
