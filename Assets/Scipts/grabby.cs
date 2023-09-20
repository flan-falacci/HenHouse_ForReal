﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class grabby : MonoBehaviour
{
    public Image hand;

    float t;
    public float lerpSpeed; 

    public AudioSource bawk;
    public AudioSource exp;

     Vector3 tableTime; 

    int chickenCount; 

    public ParticleSystem blood;

    public GameObject table;
    public Light dirLight;
    public GameObject tableLight; 

     void Start()
    {
        chickenCount = 0;
        tableTime = new Vector3(-1.51f, 1.14f, -1.44f);
    }

    void Update()
    {
        hand.transform.position = Input.mousePosition;

        if (chickenCount >= 8)
        {
            t += Time.deltaTime * lerpSpeed; 
            //move the camera in
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, tableTime, t);
            Camera.main.transform.LookAt(table.transform);
            //lower the light 
            dirLight.intensity = Mathf.Lerp(dirLight.intensity, 0, t);
            RenderSettings.fogColor = Color.black;
            tableLight.SetActive(true);
           // SceneManager.LoadScene("StartHouse3");
        }
    }
     void FixedUpdate()
    {
        Ray grabRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit; 

        if (Physics.Raycast(grabRay, out hit, 100))
        {
          
            hand.color = Color.red; 

            if (Input.GetMouseButton(0))
            {
                bawk.Play();
                exp.Play();

                ParticleSystem.Instantiate(blood, hit.transform.position, Quaternion.Euler(-90,0,0));
                hit.transform.gameObject.SetActive(false);
                Debug.Log("harvested");
                chickenCount++; 
            }
        }
        else
        {
            hand.color = Color.white; 
        }
    }
}
