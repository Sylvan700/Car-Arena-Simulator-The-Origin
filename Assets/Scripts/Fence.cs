using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fence : MonoBehaviour
{


    void Start()
    {
        
    }


    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Touched");

        collision.rigidbody.velocity = Vector3.zero;

    }

}
