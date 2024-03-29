﻿using System.Collections;
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

                if (index == vehicules.Count - 1)
                {
                    index = 0;
                }
                else { index++; }

                // Seul moyen trouver actuellement pour rendre actif les effets du pouvoir de Loli car
                if (index == 1)
                {
                    bodyCar.mass = 2.0f;
                    speed = 450;
                }

        }

        if (index == 0)
        {
            visual = GetComponent<SpriteRenderer>();
            body = GetComponent<CapsuleCollider2D>();
            GetComponent<Sprite>();
            visual.sprite = skin1;

            transform.localScale = new Vector3(0.08299329f, -0.06767181f, 1.0f);
            body.size = new Vector2(2.843039f, 8.518582f);
            bodyCar.mass = 1.2f;
            bodyCar.drag = 1.2f;
            bodyCar.angularDrag = 15;
            speed = 500;
            maxSpeed = 150;
            rotationForce = 100;
            steering = 50;
        }
        if (index == 1)
        {
            visual = GetComponent<SpriteRenderer>();
            GetComponent<Sprite>();

            visual.sprite = skin2;
            transform.localScale = new Vector3(0.08845746f, -0.07332288f, 1.0f);
            body.size = new Vector2(5.033408f, 8.053495f);
            bodyCar.drag = 2f;
            bodyCar.angularDrag = 20;
            maxSpeed = 150;
            rotationForce = 100;
            steering = 50;

        }
        if (index == 2)
        {
            visual = GetComponent<SpriteRenderer>();
            body = GetComponent<CapsuleCollider2D>();
            GetComponent<Sprite>();
            visual.sprite = skin3;

            //transform.localScale = new Vector3(0.08142736F, -0.06519713F, 1.0f);
            //body.size = new Vector2(3.588842f, 8.480232f);
            bodyCar.mass = 1.5f;
            bodyCar.drag = 1.5f;
            bodyCar.angularDrag = 25;
            speed = 450;
            maxSpeed = 150;
            rotationForce = 150;
            steering = 45;
        }
        if (index == 3)
        {
            visual = GetComponent<SpriteRenderer>();
            body = GetComponent<CapsuleCollider2D>();
            GetComponent<Sprite>();
            visual.sprite = skin4;

            transform.localScale = new Vector3(0.075381f, -0.09205688f, 1.0f);
            body.size = new Vector2(2.516712f, 9.137218f);
            bodyCar.mass = 0.9f;
            bodyCar.drag = 2f;
            bodyCar.angularDrag = 40;
            speed = 480;
            maxSpeed = 150;
            rotationForce = 100;
            steering = 50;
        }
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

                if (inputY == 1f)
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
                    bodyCar.mass = 10.0F;
                    speed = 1500;

                    cooldown = 0;

                }

                if (timeCapacity > 2.0F)
                {

                    GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f, 255f);

                    bodyCar.mass = 2.0F;
                    speed = 450;

                    capacityIsActive = false;

                    timeCapacity = 0;

                }

                break;

            case "Pope":


                if (inputAction != 0 && cooldown > 5)
                {

                    transform.localScale = new Vector3(0.08142736F*2.5f, -0.06519713F*2.5f, 1.0f*2);

                    capacityIsActive = true;

                    cooldown = 0;

                }

                if (timeCapacity > 2.0F)
                {

                    transform.localScale = new Vector3(0.08142736F, -0.06519713F, 1.0f);

                    capacityIsActive = false;

                    timeCapacity = 0;

                }

                break;

            case "Pork":

                if (inputY == 1f)
                {
                    visual.sprite = skin6;
                }
                else
                {
                    visual.sprite = skin4;
                }


                if (inputAction != 0 && cooldown > 7)
                {
                    GetComponent<SpriteRenderer>().color = new Color(255f, 72f, 0f, 255f);
                    speed = speed * 20;

                    capacityIsActive = true;

                    cooldown = 0;

                }

                if (timeCapacity > 2.0F)
                {
                    GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f, 255f);
                    speed = speed / 20;
                    capacityIsActive = false;

                    timeCapacity = 0;

                }

                break;

        }

    }

    public void Update()
    {
        // Player 3 & 4 n'on pas accès au changement de perso pour l'instant, a corriger dans un avenir proche
        if (Manager.MesJoueurs.Count > 1)
        {

            switch (player.name)
            {

                case "PlayerOne":

                    inputX = Input.GetAxis("Horizontal");
                    inputY = Input.GetAxis("Vertical");
                    inputAction = Input.GetAxis("Jump");
                    inputSwitch = Input.GetKeyDown(KeyCode.G);

                    Manager.nomPersoPlayer1 = player.name + "  " + vehicules[index];

                    SwitchHero();
                    Capacity();

                    break;

                case "PlayerTwo":
                    inputX = Input.GetAxis("Horizontal2");
                    inputY = Input.GetAxis("Vertical2");
                    inputAction = Input.GetAxis("Jump2");
                    inputSwitch = Input.GetKeyDown(KeyCode.RightControl);

                    Manager.nomPersoPlayer2 = player.name + "  " + vehicules[index];

                    SwitchHero();
                    Capacity();

                    break;

                case "PlayerThree":
                    inputX = Input.GetAxis("Horizontal3");
                    inputY = Input.GetAxis("Vertical3");
                    inputAction = Input.GetAxis("Jump3");
                    inputSwitch = Input.GetButtonDown("Change3");

                    SwitchHero();
                    Capacity();

                    break;

                case "PlayerFour":
                    inputX = Input.GetAxis("Horizontal4");
                    inputY = -Input.GetAxis("Vertical4");
                    inputAction = Input.GetAxis("Jump4");
                    inputSwitch = Input.GetButtonDown("Change4");

                    SwitchHero();
                    Capacity();

                    break;

            }

        }
        else
        {
            inputX = 0;
            inputY = 0;
        }

        if (Manager.scorePlayer1 == 0 && gameObject.name == "PlayerOne")
        {
            
            Manager.MesJoueurs.Remove("PlayerOne");
            Destroy(gameObject);

        }

        if (Manager.scorePlayer2 == 0 && gameObject.name == "PlayerTwo")
        {
            
            Manager.MesJoueurs.Remove("PlayerTwo");
            Destroy(gameObject);

        }
        if (Manager.scorePlayer3 == 0 && gameObject.name == "PlayerThree")
        {
            
            Manager.MesJoueurs.Remove("PlayerThree");
            Destroy(gameObject);

        }
        if (Manager.scorePlayer4 == 0 && gameObject.name == "PlayerFour")
        {
            
            Manager.MesJoueurs.Remove("PlayerFour");
            Destroy(gameObject);

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
