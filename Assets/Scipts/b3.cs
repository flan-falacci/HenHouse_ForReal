using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class b3 : MonoBehaviour
{
    public float timer;
    float limit; 

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        limit = 82; 
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; 

        if (timer >= limit)
        {
            SceneManager.LoadScene("EndHouse4");
        }
    }
}
