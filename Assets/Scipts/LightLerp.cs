using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightLerp : MonoBehaviour
{
    Vector3 startAngle;
    Vector3 endAngle;
    float t;
    public float riseRate;

    Light myLight;

    void Start()
    {
        startAngle = new Vector3(-152.8f,-30,-1.5f);
        endAngle = new Vector3(-19.7f,-30,0);

        myLight = GetComponent<Light>();

        transform.eulerAngles = startAngle;
    }

    void Update()
    {
        t += Time.deltaTime * riseRate;

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(endAngle), t);
    }
}
