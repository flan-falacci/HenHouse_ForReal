using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class RestartScene : MonoBehaviour
{
    private string thisSceneName;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Scene thisScene = SceneManager.GetActiveScene();
            thisSceneName = thisScene.name; 
            SceneManager.LoadScene(thisSceneName);
        }
    }
}
