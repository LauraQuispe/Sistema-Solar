using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segundoscript : MonoBehaviour
{ //Script Orbitar
  //Pivot en el Sol
  // Start is called before the first frame update

    public Vector3 puntoDeRotacion = new Vector3(1, 1, 1);
    public Vector3 axisDeRotacion = new Vector3(0, 1, 0);

    public Transform Pivot;

    public float velocidadDeRotacion = 1;
    void Update()
    {

        transform.RotateAround(Pivot.position, axisDeRotacion, velocidadDeRotacion * Time.deltaTime);
        Debug.Log("p");

    }
}