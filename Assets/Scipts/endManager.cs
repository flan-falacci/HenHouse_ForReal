using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class endManager : MonoBehaviour
{
    public Text sceneCountText; 

    // Start is called before the first frame update
    void Start()
    {
        sceneCountText.text = "you've seen " + sceneChecker.sceneCount + "/9 possible scenes"; 
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true; 
    }

   public void PlayAgain()
    {
        SceneManager.LoadScene("StartHouse"); 
    }
}
