using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChecker : MonoBehaviour
{
    public static int sceneCount;
    // Start is called before the first frame update
    void Start()
    {
       sceneCount += 1;

        Debug.Log("scenes witnessed: " + sceneCount);
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.SetActive(false);
    }
}
