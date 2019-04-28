using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public UnityEngine.UI.Slider slider;
    private bool isPaused = false;
    public AudioSource audio;
    public AudioSource gun;
    public AudioSource click;

    // Use this for initialization
    void Start()
    {
        audio.GetComponent<AudioSource>();
        gun.GetComponent<AudioSource>();
        click.GetComponent<AudioSource>();
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
        audio.Pause();                                                          //Stop sounds
        gun.volume = 0;
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
        click.Play(0);
        audio.Play(0);                                                                 //Restart
        gun.volume = 0.2f;
        transform.Find("Menu").gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void CambiarEscena(string _newScene)
    {
        click.Play(0);
        //Change scene
        SceneManager.LoadScene(_newScene);
    }

    public void changeVolume()
    {
        audio.volume = slider.value;
    }
    
}
