using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCube : MonoBehaviour
{
    // Start is called before the first frame update
  
    // Update is called once per frame
    float h = 0.1f, angulo;
    Vector3 posicion;
    void Update()
    {
        posicion = gameObject.GetComponent<Transform>().position;
        Vector3 fuerza = Vector3.zero;
        //Mapeado de botones
        if (Input.GetButtonDown("Bot A"))
        {
            print("A");
        }
        if (Input.GetButtonDown("Bot B"))
        {
            print("B");
        }
        if (Input.GetButtonDown("Bot Y"))
        {
            print("Y");
        }
        if (Input.GetButtonDown("Bot X"))
        {
            print("X");
        }
        if (Input.GetButtonDown("Bot LB"))
        {
            print("LB");
        }
        if (Input.GetButtonDown("Bot RB"))
        {
            print("RB");
        }
        if (Input.GetButtonDown("Bot Back"))
        {
            print("Back");
        }
        if (Input.GetButtonDown("Bot Start"))
        {
            print("Start");
        }
        if (Input.GetButtonDown("Bot JSI"))
        {
            print("JoyStick Izquierdo");
        }
        if (Input.GetButtonDown("Bot JSD"))
        {
            print("JoyStick Derecho");
        }

        //Mapeado de Palancas

        float an1 = Input.GetAxis("Left Analog X");
        float an2 = Input.GetAxis("Left Analog Y");
        float an3 = Input.GetAxis("Gatillo");
        float an4 = Input.GetAxis("Right Analog X");
        float an5 = Input.GetAxis("Right Analog Y");

        //Movimiento Básico
        if (an1 > 0.05)
        {
            fuerza.x += an1;
            print("Analogo X Izquierdo = " + an1);
        }
        if (an1 < -0.05)
        {
            fuerza.x += an1;
            print("Analogo X Izquierdo = " + an1);
        }
        if (an2 > 0.02)
        {
            fuerza.z -= an2;
            print("Analogo Y Izquierdo = " + an2);
        }
        if (an2 < -0.02)
        {
            fuerza.z -= an2;
            print("Analogo Y Izquierdo = " + an2);
        }
        if (an3 > 0)
        {
            print("Gatillo Derecho = " + an3);
        }
        if (an3 < 0)
        {
            print("Gatillo Izquierdo = " + an3);
        }

        if (an4 > 0.06)
        {
            transform.Rotate(Vector3.down, an4);
            print("Analogo X Derecho = " + an4);
        }
        if (an4 < -0.06)
        {
            transform.Rotate(Vector3.up, -an4);
            print("Analogo X Derecho = " + an4);
        }
        if (an5 > 0.06 )
        {
            transform.Rotate(Vector3.left, an5);
            print("Analogo Y Derecho = " + an5);
        }
        if (an5 < -0.06)
        {
            transform.Rotate(Vector3.right, -an5);
            print("Analogo Y Derecho = " + an5);
        }

        //Mapeado de Flechas

        float an6 = Input.GetAxis("Bin Analog X");
        float an7 = Input.GetAxis("Bin Analog Y");
        if (an6 > 0)
        {
            print("Flecha Derecha = " + an6);
        }
        if (an6 < 0)
        {
            print("Flecha Izquierda = " + an6);
        }
        if (an7 > 0)
        {
            print("Flecha Arriba = " + an7);
        }
        if (an7 < 0)
        {
            print("Flecha Abajo = " + an7);
        }
        if (Input.GetKey(KeyCode.W))
            fuerza += Vector3.up;
        if (Input.GetKey(KeyCode.S))
            fuerza += Vector3.down;

        //Joystick 2
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.down, Space.Self);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, Space.Self);
        if (Input.GetKey(KeyCode.UpArrow))
            fuerza.z += 1;
        if (Input.GetKey(KeyCode.DownArrow))
            fuerza.z += -1;


        angulo = gameObject.GetComponent<Transform>().rotation.y;
        fuerza.x += fuerza.x * Mathf.Cos(angulo) - fuerza.z * Mathf.Sin(angulo);
        fuerza.z += fuerza.z * Mathf.Sin(angulo) + fuerza.y * Mathf.Cos(angulo);

        posicion += fuerza * h;
        gameObject.GetComponent<Transform>().position = posicion;
    }
}
