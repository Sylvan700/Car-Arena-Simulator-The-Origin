using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiculeTemplate : MonoBehaviour
{

    // Weird "instanciation/declaration" of our rigidbody  
    public Rigidbody2D bodyCar;
    // Variable vertical speed of the car
    public float speed = 200.0f;
    public float maxSpeed;
    // Variable rotation speed of the car
    public float rotationForce = 20.0f;
    public float steering;

    public void OnCollisionEnter2D(Collision2D collision)
    {

        //Rigidbody2D rigidbody2D = new Rigidbody2D();

        //rigidbody2D.GetComponent<Rigidbody2D>();

        Debug.Log("ça marche lol");

        //if (collision.gameObject.tag == "PlayerTwo" || collision.gameObject.tag == "PlayerOne")
        {

            // rigidbody2D.AddRelativeForce(Vector3.up * Time.deltaTime * speed);

            // collision.rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * speed);

            // ForceMode2D.Impulse

            //collision.contacts[0].
            //collision.rigidbody.AddForce(Vector3.up * speed / 100, ForceMode2D.Impulse);

            // collision.gameObject.transform.Translate(Vector3.up * Time.deltaTime * speed); Fonction + ou -
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("LavaTrap"))
        {      
            
        }              

    }

}
