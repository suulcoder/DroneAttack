using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule : MonoBehaviour {

    public AudioSource audioCapsule;

    // Use this for initialization
    void Start() {
        audioCapsule.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {

    }

    private void OnMouseEnter()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        
        if (Physics.Raycast(myRay, out hitInfo))
        {
            hitInfo.transform.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    private void OnMouseExit()
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.black;
    }

    private void OnMouseDown()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        
        if (Physics.Raycast(myRay, out hitInfo))
        {
            audioCapsule.Play();
            hitInfo.transform.gameObject.GetComponent<Rigidbody>().AddForce((hitInfo.collider.gameObject.transform.position - hitInfo.point).normalized * 50, ForceMode.VelocityChange);
        }
    }




}


