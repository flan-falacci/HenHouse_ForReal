using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class wolfAI : MonoBehaviour
{
    public GameObject prey;
    public float speed;
    float startY;
    AudioSource chomp;

    float timer; 

    // Start is called before the first frame update
    void Start()
    {
        startY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.deltaTime; 

        transform.LookAt(new Vector3(prey.transform.position.x, 0, prey.transform.position.z));
        transform.position += transform.forward * Time.deltaTime * speed;
        transform.position = new Vector3(transform.position.x, startY, transform.position.z);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

        //gradually increase wolf speed
        if (timer >= 20)
        {
            speed = 3; 
        }
        if (timer >= 30)
        {
            speed = 5; 
        }
    }

  
    }

    
  
