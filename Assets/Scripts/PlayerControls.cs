using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : VehiculeTemplate
{
    public void Cooldown()
    {

    }

    public void SwitchHero()
    {

        if (inputSwitch)
        {
            if (index == vehicules.Count)
                index = 0;

            else { index++; }

            if(index == 1)
            {
                bodyCar.mass = 2f;
                speed = 450;
            }
            
        }

        if(index == 0)
        {
            visual = GetComponent<SpriteRenderer>();
            body = GetComponent<CapsuleCollider2D>();

            GetComponent<Sprite>();
            visual.sprite = skin1;
            transform.localScale = new Vector3(0.1592456f, -0.1279333f, 1.0f);
            body.offset = new Vector2(-0.2479172f, 0.1459049f);
            body.size = new Vector2(1.686367f, 4.281521f);
            bodyCar.mass = 1.2f;
            bodyCar.drag = 1.2f;
            bodyCar.angularDrag = 20;
            speed = 500;
            maxSpeed = 150;
            rotationForce = 100;
            steering = 50;
        }
        if (index == 1)
        {
            visual = GetComponent<SpriteRenderer>();
            GetComponent<Sprite>();
            //visual.sprite = skin2;
            transform.localScale = new Vector3(0.08363746f, -0.074713f, 1.0f);
            body.offset = new Vector2(-6.490071f, 1.036186f);
            body.size = new Vector2(5.119109f, 8.594376f);
            bodyCar.drag = 2f;
            bodyCar.angularDrag = 20;
            maxSpeed = 150;
            rotationForce = 100;
            steering = 50;

            visual = GetComponent<SpriteRenderer>();
            GetComponent<Sprite>();
            visual.sprite = skin2;
        }
        if(index == 2)
        {

        }

        // Change sprites, stats, ...

    }

    public void Capacity()
    {

        if (capacityIsActive)
            timeCapacity += Time.deltaTime;

        if (cooldownActive)
            cooldown += Time.deltaTime;

        switch (vehicules[index])
        {
            case "Sodic":

                if (inputAction != 0 && cooldown > 5) 
                {

                    GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.2f);
                   // visual = GetComponent<SpriteRenderer>();
                    //visual.enabled = false;

                    
                    capacityIsActive = true;
                    collision = GetComponent<Collider2D>();
                    collision.isTrigger = true;

                    cooldown = 0;

                    // cooldownActive = true;       

                }

                if (timeCapacity > 1.0F)
                {

                    GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f, 255f);
      
                    collision = GetComponent<Collider2D>();
                    collision.isTrigger = false;
                    capacityIsActive = false;
                    timeCapacity = 0;

                }

                break;

            case "Loli":

                if(inputY == 1f)
                {
                    visual.sprite = skin5;
                }
                else
                {
                    visual.sprite = skin2;
                }

                if (inputAction != 0 && cooldown > 7) 
                {

                   GetComponent<SpriteRenderer>().color = new Color(0f, 237f, 255f, 255f);

                    capacityIsActive = true;

                    bodyCar = GetComponent<Rigidbody2D>();
                    bodyCar.mass = 5;
                    speed = 1000;

                    cooldown = 0;

                }

                if (timeCapacity > 2.0F)
                {

                    GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f, 255f);

                    bodyCar.mass = 2F;
                    speed = 450;

                    capacityIsActive = false;

                    timeCapacity = 0;

                }

                break;

            case "Pope":


                if (inputAction != 0 && cooldown > 7)
                {

                    //Instantiate(bumpCapacity, (Vector2)spawn, Quaternion.Euler(0, 0, Random.Range(-360f, 360f)));
                    capacityIsActive = true;

                    cooldown = 0;

                }

                if (timeCapacity > 2.0F)
                {

                    capacityIsActive = false;

                    timeCapacity = 0;

                }



                break;

        }    
        
    }


    new public void Update()
    {

        switch (player.name)
        {

            case "PlayerOne":

                inputX = Input.GetAxis("Horizontal");
                inputY = Input.GetAxis("Vertical");
                inputAction = Input.GetAxis("Jump");
                inputSwitch = Input.GetKeyDown(KeyCode.G);
                

                SwitchHero();
                Capacity();        

                break;

            case "PlayerTwo":
                inputX = Input.GetAxis("Horizontal2");
                inputY = Input.GetAxis("Vertical2");
                inputAction = Input.GetAxis("Jump2");
                // inputSwitch = Input.GetAxis("Change2");
                

                SwitchHero();
                Capacity();           

                break;

            case "PlayerThree":
                inputX = Input.GetAxis("Horizontal3");
                inputY = Input.GetAxis("Vertical3");
                inputAction = Input.GetAxis("Jump3");
                // inputSwitch = Input.GetAxis("Change3");

                SwitchHero();
                Capacity();

                break;

            case "PlayerFour":
                inputX = Input.GetAxis("Horizontal4");
                inputY = Input.GetAxis("Vertical4");
                inputAction = Input.GetAxis("Jump4");
                // inputSwitch = Input.GetAxis("Change4");

                SwitchHero();
                Capacity();

                break;

        }
        
    }

    // Fixed Update is an Update at 50 frames per second mainly used for physics interactions in the unity engine
    // The function is called after the basic Update one right above
    /// <summary>
    /// First, we'll find basic controls of our vehicules
    /// </summary>
    void FixedUpdate()
    {
        // It's variables from 0 to 1 depending of the player pressuring or not horizontals and verticals inputs. Z,Q,S,D for movement. space for action. up,left,right,down for movement. numpad "0" for action.
        // up,left,right,down for movement. numpad "0" for action.


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
