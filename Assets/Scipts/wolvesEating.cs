using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class wolvesEating : MonoBehaviour
{
    public float timer; 

    // Start is called before the first frame update
    void Start()
    {
        timer = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        float count = 62;
        timer += Time.deltaTime; 

        if (timer >= count)
        {
            SceneManager.LoadScene("StartHouse3");
        }
    }
}
