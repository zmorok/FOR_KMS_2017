using NUnit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class КамераЧасти2 : MonoBehaviour {


    private Vector3 startV, endV;
    private Quaternion startQ, endQ;

    private bool move;
    private float offset = 0f, speed = 0.02f;

    public void Click1()
    {
        move = true;
        startV = transform.position;
        startQ = transform.rotation;

        endV = new Vector3(-5.183193f, 1.324573f, -4.71097f);
        endQ = Quaternion.Euler(18.4f, 46.05f, 0f);
    }

    public void Click2()
    {
        move = true;
        startV = transform.position;
        startQ = transform.rotation;

        endV = new Vector3(5.725982f, 1.4351f, -9.128183f);
        endQ = Quaternion.Euler(21.9f, -27.15f, 0f);
    }

    public void Click3()
    {
        move = true;
        startV = transform.position;
        startQ = transform.rotation;

        endV = new Vector3(7.151969f, 2.151893f, 4.550575f);
        endQ = Quaternion.Euler(27.65f, -134.55f, 0f);
    }

    private void Update()
    {
        if (move)
        {
            offset += speed;
            transform.position = Vector3.Lerp(startV, endV, offset);
            transform.rotation = Quaternion.Slerp(startQ, endQ, offset);
            if (offset >= 1f)
            {
                move = false;
                offset = 0f;
            }
        }

        ///////////////////////
        ///////////////////////

        //float x = Input.GetAxis("Horizontal") / 4;
        //float z = Input.GetAxis("Vertical") / 4;
        //if (x != 0 || z != 0)
        //{
        //    Vector3 newPos = transform.position + transform.TransformDirection(new Vector3(x, 0, z));
        //    transform.position = newPos;
        //}

        //if (Input.GetMouseButton(1))
        //{
        //    float xG = Input.GetAxis("Mouse X");
        //    float yG = Input.GetAxis("Mouse Y");

        //    transform.RotateAround(transform.position, Vector3.up, xG);
        //    transform.RotateAround(transform.position, transform.right, -yG);
        //}
    }
}
