using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoment : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 0.05f);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -0.05f);
        }

        Rigidbody body = GetComponent<Rigidbody>();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(0, 40, 0, ForceMode.Impulse);
        }

        if(transform.position.y <= - 40)
        {
            transform.position = new Vector3(-0.87f, 3.68f, -9);
        }


    }
}
