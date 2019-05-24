using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{

    public float BumpForce = 1;

    void Start()
    {
        
    }



    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Bumped");

        collision.rigidbody.AddRelativeForce(-Vector3.up * BumpForce * 5000 * Time.deltaTime);

    }

}
