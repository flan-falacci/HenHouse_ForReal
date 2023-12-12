using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class pauseMenu : MonoBehaviour
{
    public GameObject pausemenuUI;
    //Scene thisScene; 

    void Start ()
    {
      //  thisScene = SceneManager.GetActiveScene(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pausemenuUI.SetActive(true);
            Cursor.visible = true;
            AudioListener.pause = true; 
          
           
        }
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pausemenuUI.SetActive(false);
        AudioListener.pause = false; 
    }

    public void QuitButton()
    {
        Application.Quit(); 
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("StartHouse");
        goodEnding.goodendingunlocked = false;
        AudioListener.pause = false; 
    }
}
