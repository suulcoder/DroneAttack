using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Find("score").GetComponent<UnityEngine.UI.Text>().text = "ENEMIES ALIVE: " + Manager.enemigos;

    }
}
