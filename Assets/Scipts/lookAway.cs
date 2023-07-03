using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lookAway : MonoBehaviour
{
    public GameObject player;
    float distance;
    bool barked;

    public static int barkCount;
    int limit; 

    public float tooClose;
    float runspeed;
    float timer; 


    // Start is called before the first frame update
    void Start()
    {
        barked = false;
        barkCount = 0;
        limit = 20;
        runspeed = 25;
        timer = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        //this script will make the gameobject look at the player when theyre a certain distance apart
        //and make the gameobject look away from the player when theyre a certain shorter distance apart 

        distance = Vector3.Distance((gameObject.transform.position), (player.transform.position));

        //turn towwards
        if (distance > tooClose)
        {
            gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, player.transform.eulerAngles.y -180 ,gameObject.transform.eulerAngles.z);
            barked = false; 
        }

        //turn away
        else if (distance <= tooClose)
        {
            gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, player.transform.eulerAngles.y, gameObject.transform.eulerAngles.z);
            if (!barked)
            {
                GetComponent<AudioSource>().Play();
                barked = true;
                barkCount ++;
            }
        }

        //run away once limit reached 
         if (barkCount >= limit)
        {
            gameObject.transform.eulerAngles = new Vector3(transform.eulerAngles.x, Random.Range(-180, 180), transform.eulerAngles.z);
            transform.position += transform.up * Time.deltaTime * runspeed;

            
            timer += Time.deltaTime; 
            if (timer >= 10)
            {
                SceneManager.LoadScene("StartHouse2");
            }
        }

    }

}
