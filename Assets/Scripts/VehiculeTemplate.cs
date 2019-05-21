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

}
