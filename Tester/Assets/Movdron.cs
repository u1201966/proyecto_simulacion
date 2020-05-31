using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movdron : MonoBehaviour
{
    Vector3 posicion;
    private float grav = 0.1f;
    void FixedUpdate()
    {
        posicion = gameObject.GetComponent<Transform>().position;
        float an3 = Input.GetAxis("Gatillo");
        float an1 = Input.GetAxis("Left Analog X");
        float an2 = Input.GetAxis("Left Analog Y");

        if (posicion.y >= 0)
        {
            posicion.y -= grav;

            if (an3 > 0.3)
            {
                posicion.y += an3;
            }
            if (posicion.y >= 1 )
            {
                posicion.x += an1;
                posicion.z += -1*an2;
            }

        }
        else
            posicion.y = 0;
        gameObject.GetComponent<Transform>().position = posicion;
    }

}
