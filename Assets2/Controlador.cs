﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    float h=0.1f,angulo;
    Vector3 posicion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        posicion = gameObject.GetComponent<Transform>().position;
        Vector3 fuerza= Vector3.zero;

        //Joystick 1
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

        angulo =gameObject.GetComponent<Transform>().rotation.y;
        fuerza.x += fuerza.x * Mathf.Cos(angulo)-fuerza.z*Mathf.Sin(angulo);
        fuerza.z += fuerza.z * Mathf.Sin(angulo)+fuerza.y*Mathf.Cos(angulo);

        posicion += fuerza*h;
        gameObject.GetComponent<Transform>().position=posicion;

        Debug.Log(angulo+"ola");
    }
}
