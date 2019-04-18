using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    private bool isPaused = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = (isPaused) ? Continue() : PauseGame();
        }
    }

    public bool PauseGame()
    {
        //Search for menu
        transform.Find("Menu").gameObject.SetActive(true);
        Time.timeScale = 0.0f;
        return true;
    }


    public bool Continue()
    {
        resume();
        return false;
    }

    public void resume()
    {
        //Search for menu
        transform.Find("Menu").gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void CambiarEscena(string _newScene)
    {
        //Change scene
        SceneManager.LoadScene(_newScene);
    }

}
