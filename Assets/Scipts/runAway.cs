using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class runAway : MonoBehaviour
{
    public float timer; 
    public float speed;
    public float Limit; 

    // Start is called before the first frame update
    void Start()
    {
        timer = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;

        timer += Time.deltaTime; 

        if (timer >= Limit)
        {
            SceneManager.LoadScene("EndHouse4"); 
        }
    }
}
