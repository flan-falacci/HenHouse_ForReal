using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class goodEnding : MonoBehaviour
{
    AudioSource ding;
    public AudioSource yippee;
    public static bool goodendingunlocked; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine("goodending");
            goodendingunlocked = true; 
        }
    }

    IEnumerator goodending()
    {
        yippee.Play();

        yield return new WaitForSeconds(1);


        SceneManager.LoadScene("ending");
        yield return null; 
    }
}
