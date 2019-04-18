using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

    public bool instructionsState = false;


	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        
        
    }

    public void CambiarEscena(string _newScene)
    {
        //Change scene
        transform.Find("ShowText").GetComponent<UnityEngine.UI.Text>().text = "Loading...";
        SceneManager.LoadScene(_newScene);
    }

    public void showInstructions()
    {
        if (instructionsState)
        {
            instructionsState = false;
            transform.Find("ShowText").GetComponent<UnityEngine.UI.Text>().text = "";
        }
        else
        {
            instructionsState = true;
            transform.Find("ShowText").GetComponent<UnityEngine.UI.Text>().text =
                @"Hello!  You are part of the resistance. The war between
drones and humans is greater than never. You were sent here
to kill 29 drones arround the tallest building in the city. 
Kill them all!.";
        }
    }


}
