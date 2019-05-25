using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaTrap : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("Touched");

        Destroy(collision.gameObject);

    }



}
