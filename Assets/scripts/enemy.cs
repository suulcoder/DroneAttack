using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Rotate all drones
        transform.Rotate(new Vector3(0f, 0f, 0.35f));
        

	}
}
