using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wolfScene : MonoBehaviour
{

    public float driftSpeed;
    public Transform wolf;
    public float timer; 
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {

        float count = 35;
        transform.position += new Vector3(0,0,1) * driftSpeed * Time.deltaTime;
        //transform.LookAt(wolf);
        timer += Time.deltaTime; 

        if (timer >= count)
        {
            SceneManager.LoadScene("StartHouse2");
        }
    }
}
