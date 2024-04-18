using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject welcomeSection;
    //public GameObject studySection;
    //public GameObject startSection;

    public GameObject PreSection;
    public GameObject PostSection;

    public GameObject Earth;
    public GameObject Mars;

    bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("scale");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("select");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("rotate");
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("flick send");
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene("flick receive");
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            preToPostBtn();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("playground");
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            SceneManager.LoadScene("play intro");
        }

    }

    public void welcomeToStudyBtn()
    {
        SceneManager.LoadScene("select");
    }

    public void studyToStartBtn()
    {
        //studySection.SetActive(false);
        //startSection.SetActive(true);
    }

    public void preToPostBtn()
    {
        PreSection.SetActive(false);
        PostSection.SetActive(true);
    }

    public void LoadSelectBtn()
    {
        SceneManager.LoadScene("select play");
    }

    public void LoadScaleBtn()
    {
        SceneManager.LoadScene("scale play");
    }

    public void LoadRotateBtn()
    {
        SceneManager.LoadScene("rotate play");
    }

    public void LoadFlickSendBtn()
    {
        SceneManager.LoadScene("flick send play");
    }

    public void LoadFlickReceiveBtn()
    {
        SceneManager.LoadScene("flick receive play");
    }

    public void earthToMarsBtn()
    {

        if (flag == false)
        {
            Earth.SetActive(false);
            Mars.SetActive(true);
            flag = true;
        }
        else if (flag == true)
        {
            Earth.SetActive(true);
            Mars.SetActive(false);
            flag = false;
        }

    }

}