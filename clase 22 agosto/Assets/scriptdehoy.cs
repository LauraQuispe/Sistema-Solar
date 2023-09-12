using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptdehoy : MonoBehaviour
    //Transform con may se refiere al componente (puede uar el tipo de datos), transform con min es el tranform del objeto con el script (mi tranfrom)
{


    public float horizontal;
    public float vertical;
    public float speed;



    // Update is called once per frame
    void Update()
   {
    horizontal = Input.GetAxis("Horizontal");
    vertical = Input.GetAxis("Vertical");

        horizontal = 3;
        vertical = 4;
        speed = 1;

    transform.position += -transform.up;
     
    }
}
