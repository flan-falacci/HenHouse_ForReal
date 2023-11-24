using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkforPrey : MonoBehaviour
{
    public GameObject prey;
    AudioSource chomp;
    Light flashlight;
    Renderer myPlaneRend; 

    // Start is called before the first frame update
    void Start()
    {
        chomp = gameObject.transform.parent.gameObject.GetComponent<AudioSource>();
        flashlight = prey.GetComponentInChildren<Light>();
        myPlaneRend = prey.GetComponentInChildren<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("collided with player");

            prey.transform.LookAt(this.transform);
            StartCoroutine("Eaten");
        }
    }

    IEnumerator Eaten()
    {
        
        flashlight.intensity = 0;
        myPlaneRend.enabled = true;
        yield return new WaitForSeconds(3);

        chomp.Play();

        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("ending");

        yield return null;
    }
}
