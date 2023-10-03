using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class fadeOut : MonoBehaviour
{
    float timer;
    float t;

    public float fadeSpeed; 


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        t = Time.deltaTime * fadeSpeed; 
  
        Text thisText = gameObject.GetComponent<Text>(); 

        if (timer >= 3)
        {
            thisText.color = Color.Lerp(thisText.color, new Color(thisText.color.r, thisText.color.g, 
                thisText.color.b, 0), t);
        }
    }
}
