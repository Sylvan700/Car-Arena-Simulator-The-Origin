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
    // var for the lifes of the car
    public string characters;
    public int index;



    public void Start()
    {
        vehicules.Add(0, "Sodic");
    }

    public void Update()
    {

        // Jamais dans le update par contre OU par une alternative... Quoique
        switch (vehicules[index])
        {

            // Inputs machin... E ou R1 ou jsp

            case "Sodic":

                Manager.nomPersoPlayer1 = "Sodic";

                // On peut tout set ici finalement: la masse, les vitesses, ...                

                



                break;
        }
    }
   

}
