using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class endManager : MonoBehaviour
{
    public Text sceneCountText;
    public Text goodEndingMsg;
    public Text badEndingMsg; 

    // Start is called before the first frame update
    void Start()
    {
        sceneCountText.text = "you've seen " + sceneChecker.sceneCount + "/10 possible scenes"; 
        if (goodEnding.goodendingunlocked == true)
        {
            goodEndingMsg.gameObject.SetActive(true);
            badEndingMsg.gameObject.SetActive(false);
        }
        else if (goodEnding.goodendingunlocked != true)
        {
            goodEndingMsg.gameObject.SetActive(false);
            badEndingMsg.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true; 
    }

   public void PlayAgain()
    {
        goodEnding.goodendingunlocked = false;
        SceneManager.LoadScene("StartHouse"); 
    }
}
