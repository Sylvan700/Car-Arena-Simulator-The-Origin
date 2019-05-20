using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controls : MonoBehaviour
{

    // Variable vertical speed of the car
    public float speed = 200.0F;

    // Variable rotation speed of the car
    public float rotationForce = 20.0F;

    // Weird "instanciation/declaration" of our rigidbody  
    new Rigidbody2D rigidbody2D;

    void Start()
    {

        // Classic Unity's assignation in order to create a variable of the rigidbody and therefore manipulate it 
        rigidbody2D = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        


    }

    // Fixed Update is an Update at 50 frames per second mainly used for physics interactions in the unity engine
    // The function is called after the basic Update one right above
    /// <summary>
    /// First, we'll find basic controls of our vehicules
    /// </summary>
    void FixedUpdate()
    {

        // It's variables from 0 to 1 depending of the player pressuring or not horizontals and verticals inputs 
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // rigidbody Y speed (vertical speed)
        rigidbody2D.AddRelativeForce(Vector3.up * inputY * speed * Time.deltaTime);

        // rigidbody X speed (horizontal speed)
        rigidbody2D.AddTorque(-rotationForce * inputX * Time.deltaTime);


    }
}
