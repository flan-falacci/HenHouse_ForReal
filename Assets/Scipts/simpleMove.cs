using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleMove : MonoBehaviour
{
    public float speed;
    float yPos;

    void Start()
    {
        yPos = transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * speed;

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * speed;
        }
    }
}