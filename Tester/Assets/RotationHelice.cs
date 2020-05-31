using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationHelice : MonoBehaviour
{
    public int type;
    private float speed, stat;
    // Start is called before the first frame update
    // Update is called once per frame
    void FixedUpdate()
    {
        float an3 = Input.GetAxis("Gatillo");
        

        if (an3 > 0.05 && speed <= 50)
        {

            speed = 50 * an3;
            if (type == 1 || type == 3)
            {
                speed = -1 * speed;
                transform.Rotate(0, speed, 0);

            }
            if (type == 2 || type == 4)
            {

                transform.Rotate(0, speed, 0);

            }
            stat = speed;
        }
        speed = stat;
    }
}
