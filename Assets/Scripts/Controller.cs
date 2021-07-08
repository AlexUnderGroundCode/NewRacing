using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Mover Car;
 
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Car.LeftRotation();
        }

        if(Input.GetKey(KeyCode.D))
        {
            Car.RightRotation();
        }

        if(Input.GetKey(KeyCode.Space))
        {
            Car.Acceleration();
        }
    }
}

