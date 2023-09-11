using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class grabby : MonoBehaviour
{
    public Image hand; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hand.transform.position = Input.mousePosition;
    }
}
