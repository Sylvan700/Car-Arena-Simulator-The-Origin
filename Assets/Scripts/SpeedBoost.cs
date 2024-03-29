﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{

    public float Boost = 1;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.CompareTag("PlayerOne") || collision.gameObject.CompareTag("PlayerTwo") || collision.gameObject.CompareTag("PlayerFour"))
        {
            collision.attachedRigidbody.AddRelativeForce(Vector3.up * Boost * 10000 * Time.deltaTime);
        }
        else
        {
            collision.attachedRigidbody.AddRelativeForce(-Vector3.up * Boost * 10000 * Time.deltaTime);
        }


        // collision.gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(Vector3.up * 1000 * Time.deltaTime);

        // .AddRelativeForce(Vector3.up * inputY * speed * Time.deltaTime);

    }

}
