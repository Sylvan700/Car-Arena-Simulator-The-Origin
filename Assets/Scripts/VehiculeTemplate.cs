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
    public float rotationForce = 20.0F;
    public float steering;
    // var for the lifes of the car
    public int lifePoint = 3;

    public void Start()
    {
        // bodyCar.GetComponent<Rigidbody2D>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        //Rigidbody2D rigidbody2D = new Rigidbody2D();

        //rigidbody2D.GetComponent<Rigidbody2D>();

        Debug.Log("ça marche lol");

        if (collision.gameObject.tag == "Vehicule")
        {

            // rigidbody2D.AddRelativeForce(Vector3.up * Time.deltaTime * speed);

            // collision.rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * speed);

            // ForceMode2D.Impulse

            //collision.contacts[0].
            //collision.rigidbody.AddForce(Vector3.up * speed / 100, ForceMode2D.Impulse);

            // collision.gameObject.transform.Translate(Vector3.up * Time.deltaTime * speed); Fonction + ou -
        }
    }

}
