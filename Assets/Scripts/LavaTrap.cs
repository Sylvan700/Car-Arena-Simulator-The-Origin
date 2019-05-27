using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaTrap : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("Touched");

        Destroy(collision.gameObject);

    }

}
