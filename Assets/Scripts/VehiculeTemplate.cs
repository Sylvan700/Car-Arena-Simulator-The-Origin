using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiculeTemplate : MonoBehaviour
{

    public Dictionary<int, string> vehicules = new Dictionary<int, string>();
    
    // Weird "instanciation/declaration" of our rigidbody  
    public Rigidbody2D bodyCar;
    // Variable vertical speed of the car
    public float speed = 200.0f;
    public float maxSpeed;
    // Variable rotation speed of the car
    public float rotationForce = 20.0f;
    public float steering;
    protected int index;
    public GameObject player;
    public Collider2D collision;
    public SpriteRenderer visual;
    protected float inputX;
    protected float inputY;
    protected float inputAction;
    protected float inputSwitch;


    public float timeCapacity=0;
    public float cooldown;

    public bool capacityIsActive = false;
    public bool cooldownActive = true;



    public void Start()
    {

        vehicules.Add(0, "Sodic");
        vehicules.Add(1, "Loli");


        //Manager.MesJoueurs.Add("PlayerThree");
        //Manager.MesJoueurs.Add("PlayerFour");

    }

    public void Update()
    {

        
    }
   

}
