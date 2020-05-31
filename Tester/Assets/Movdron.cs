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

        if (posicion.y >= 0)
        {
            posicion.y -= grav;

            if (an3 > 0.5)
            {
                posicion.y += an3;
            }

        }
        else
            posicion.y = 0;
        gameObject.GetComponent<Transform>().position = posicion;
    }

}
