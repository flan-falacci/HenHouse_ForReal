using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleMove : MonoBehaviour
{
    public float speed;
    float startSpeed; 
    float yPos;
    public bool noSprintMode; 

    void Start()
    {
        yPos = transform.position.y;
        startSpeed = speed; 
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

        if ((Input.GetKey(KeyCode.LeftShift)) && (!noSprintMode))
        {
            speed = 1;
        }
        else
        {
            speed = startSpeed; 
        }
        
    }
}