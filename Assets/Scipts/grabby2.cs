using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class grabby2 : MonoBehaviour
{
    public Image hand;

    public Camera mycam; 

    float t;
    float timer;
    public float lerpSpeed;

    bool grabbed;
    bool musicPlaying;
    bool soundplaying; 
   
    public Light spotlight;

    public AudioSource soundFX;
    public AudioSource music; 

    public GameObject walls;
    public GameObject chadWolf; 


    void Start()
    {
        soundplaying = false;
        musicPlaying = false;
    }

    void Update()
    {
        hand.transform.position = Input.mousePosition;

        if (grabbed)
        {
            hand.enabled = false; 
            t = Time.deltaTime * lerpSpeed;
            if (!soundplaying)
            {
                soundFX.Play();
                soundplaying = true; 
            }
            spotlight.intensity = Mathf.Lerp(spotlight.intensity, 0, t);
            if (spotlight.intensity <= .1f)
            {
                walls.SetActive(false);
                chadWolf.SetActive(true);

                if (!musicPlaying)
                {
                    music.Play();
                    musicPlaying = true; 
                }
                if (musicPlaying)
                {
                    timer += Time.deltaTime; 
                    if (timer >= 5)
                    {
                        SceneManager.LoadScene("EndHouse4");
                    }
                }
            }
        }
    }

    void FixedUpdate()
    {
        Ray grabRay = mycam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(grabRay, out hit, 10))
        {
            if (hit.collider.tag == "sword")
            {
                hand.color = Color.red;

                if (Input.GetMouseButton(0))
                {
                    hit.transform.gameObject.SetActive(false);
                    Debug.Log("sword grabbed");
                    grabbed = true; 
                }
            }
            else
            {
                hand.color = Color.white;
            }
        }
    }
}
