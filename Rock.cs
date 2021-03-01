﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Set up many initiating parameters 
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude, ForceMode2D.Impulse);

        
    }

    //// Update is called once per frame
    //void Update()
    //{
       
        
    //}

    void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(gameObject);

    }
}
