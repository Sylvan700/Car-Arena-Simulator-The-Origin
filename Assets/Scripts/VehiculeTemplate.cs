using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiculeTemplate : MonoBehaviour
{

    public Dictionary<int, string> vehicules = new Dictionary<int, string>();

    // Weird "instanciation/declaration" of our rigidbody  
    public GameObject preFab;
    public Rigidbody2D bodyCar;
    // Variable vertical speed of the car
    public float speed = 200.0f;
    public float maxSpeed;
    // Variable rotation speed of the car
    public float rotationForce = 20.0f;
    public float steering;
    // Index of the vehicule dictionary
    protected int index = 0;
    public GameObject player;
    public GameObject bumpCapacity;
    public Collider2D collision;
    public CapsuleCollider2D body;
    public SpriteRenderer visual;
    public Sprite skin1;
    public Sprite skin2;
    public Sprite skin3;
    public Sprite skin4;
    public Sprite skin5;
    public Sprite skin6;
    protected float inputX;
    protected float inputY;
    protected float inputAction;
    protected bool inputSwitch;

    public float timeCapacity=0;
    public float cooldown;

    public bool capacityIsActive = false;
    public bool cooldownActive = true;



    public void Start()
    {

        vehicules.Add(0, "Sodic");
        vehicules.Add(1, "Loli");
        vehicules.Add(2, "Pope");
        vehicules.Add(3, "Pork");

    }

}
