using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controls : VehiculeTemplate
{

    //void Start()
    //{


    //}

    // Fixed Update is an Update at 50 frames per second mainly used for physics interactions in the unity engine
    // The function is called after the basic Update one right above
    /// <summary>
    /// First, we'll find basic controls of our vehicules
    /// </summary>
    void FixedUpdate()
    {

        // It's variables from 0 to 1 depending of the player pressuring or not horizontals and verticals inputs. up,left,right,down for movement. numpad "0" for action.
        // numpad keypad for alternative movement.
        float inputX = Input.GetAxis("Horizontal2");
        float inputY = Input.GetAxis("Vertical2");
        float inputAction = Input.GetAxis("Jump2");

        //rigidbody Y speed (vertical speed)
        bodyCar.AddRelativeForce(Vector3.up * inputY * speed * Time.deltaTime);

        //rigidbody X speed (horizontal speed)
        bodyCar.AddTorque(-rotationForce * inputX * Time.deltaTime);

        // If the car is rotating, multiply her rotation by a steering value("direction assistée") and reduce the velocity of the car if it exceed the maximum speed.
        // If the car is not rotating anymore, stop his rotation movement.
        if (bodyCar.rotation >= 0.0f)
        {
            bodyCar.rotation += inputX * steering * (bodyCar.velocity.magnitude / maxSpeed);
        }
        else
        {
            bodyCar.rotation -= inputX * steering * (bodyCar.velocity.magnitude / maxSpeed);
        }

        // Drift variable made by multiplying the velocity of the car by her global x position *(2,5)
        float drift = Vector2.Dot(bodyCar.velocity, bodyCar.GetRelativeVector(Vector2.left)) * 2.5f;

        // Get a Vector2 who identify a relative force made with the drift variable.
        Vector2 relativeForce = Vector2.right * drift;

        // Add the global Vector2 obtain with "relativeForce" to the car body.
        bodyCar.AddForce(bodyCar.GetRelativeVector(relativeForce));

        // compare the magnitude of the velocity to the maximum speed variable. If it's more than the maxSpeed variable, change the velocity of the car to a lower value.
        if (bodyCar.velocity.magnitude > maxSpeed)
        {
            bodyCar.velocity = bodyCar.velocity.normalized * maxSpeed;
        }

    }

}
