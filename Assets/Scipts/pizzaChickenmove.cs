using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizzaChickenmove : MonoBehaviour
{
    public float chickenSpeed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * chickenSpeed;
    }
}
