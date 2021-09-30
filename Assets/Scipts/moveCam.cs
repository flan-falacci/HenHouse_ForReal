using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class moveCam : MonoBehaviour
{

    public Camera cam;
    public Text question;
    public Text a;
    public Text b;
    public Text c; 
    public Vector3 cameraGoal;
    public Vector3 cameraRotGoal;
    public GameObject Ding;
    public AudioSource makeSelection;

    public string aScene;
    public string bScene;
    public string cScene;
    bool selectionTime;



    // Start is called before the first frame update
    void Start()
    {
        //start all text invisible 
        question.color = new Color(question.color.r, question.color.g, question.color.b, 0);
        a.color = new Color(a.color.r, a.color.g, a.color.b, 0);
        b.color = new Color(b.color.r, b.color.g, b.color.b, 0);
        c.color = new Color(c.color.r, c.color.g, c.color.b, 0);

        selectionTime = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (selectionTime)
        {
            if (Input.GetKey(KeyCode.A))
            {
                Ding.GetComponent<AudioSource>().Play();
                SceneManager.LoadScene(aScene);
                //option A 
            }
            if (Input.GetKey(KeyCode.B))
            {
                Ding.GetComponent<AudioSource>().Play();
                SceneManager.LoadScene(bScene);

            }
            if (Input.GetKey(KeyCode.C))
            {
                Ding.GetComponent<AudioSource>().Play();
                SceneManager.LoadScene(cScene);
                //option C
            }
        }

    }

    void MakeSelection()
    {

        makeSelection.Play();
        Debug.Log("running make selection");
        if (Input.GetKey(KeyCode.A))
        {
            Ding.GetComponent<AudioSource>().Play();

            //option A 
        }
        if (Input.GetKey(KeyCode.B))
        {
            Ding.GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("wolfScene");
;        }
        if (Input.GetKey(KeyCode.C))
        {
            Ding.GetComponent<AudioSource>().Play();

            //option C
        }
    }

    //player enters the transition zone 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           
            Vector3 startPos = cam.transform.localPosition;
            Vector3 startRot = cam.transform.localEulerAngles;
            StartCoroutine(Questions(cam, question, a, b, c , cameraGoal, startPos, cameraRotGoal, startRot, Ding));
        }
    }

    //transition coroutine 
    IEnumerator Questions(Camera mycamera, Text questionstext, Text a, Text b, Text c, 
    Vector3 camGoal, Vector3 camPos, Vector3 camrotGoal, Vector3 camRot, GameObject sound)
    {
        mycamera.transform.parent = null;

            const float waitTime = 1f;
            float lerpTime = 0f;

       //play ding sound
        sound.GetComponent<AudioSource>().Play();

        //move camera and fade in text  
        while (lerpTime < waitTime)
            {

            lerpTime += Time.deltaTime * .5f;
            mycamera.transform.localPosition = Vector3.Lerp(camPos, camGoal, lerpTime);
            mycamera.transform.localEulerAngles = Vector3.Lerp(camRot, camrotGoal, lerpTime);
            float alphavalue = Mathf.Lerp(0, 1, lerpTime);
            questionstext.color = new Color(questionstext.color.r, questionstext.color.g, questionstext.color.b, alphavalue);

            yield return null; //Don't freeze Unity
            }
     
        //read out the question
        AudioSource voice = gameObject.GetComponent<AudioSource>();
        voice.Play();

        yield return new WaitForSeconds(.5f);

        //next part, fade in each answer option 

        //option a 
        float lerpTime2 = 0f; 

        while (lerpTime2 < waitTime)
        {
            lerpTime2 += Time.deltaTime * .5f;
            float alphavalue2 = Mathf.Lerp(0, 1, lerpTime2);
            a.color = new Color(a.color.r, a.color.g, a.color.b, alphavalue2);
            yield return null; 

        }
        //option b
        float lerpTime3 = 0f;
        while (lerpTime3 < waitTime)
        {
            lerpTime3 += Time.deltaTime * .5f;
            float alphavalue3 = Mathf.Lerp(0, 1, lerpTime3);
            b.color = new Color(b.color.r, b.color.g, b.color.b, alphavalue3);
            yield return null; 

        }
        //option c 
       float lerpTime4 = 0f;
        while (lerpTime4 < waitTime)
        {
            lerpTime4 += Time.deltaTime * .5f;
            float alphavalue4 = Mathf.Lerp(0, 1, lerpTime4);
            c.color = new Color(c.color.r, c.color.g, c.color.b, alphavalue4);
            yield return null;

        }

        //let the player pick an option
        makeSelection.Play();

        selectionTime = true; 

        yield return null; 
    }

}
