using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class Manager : MonoBehaviour {

    public AudioSource audioGun;
    public static int enemigos = 29;
    public GameObject explosion;

    // Use this for initialization
    void Start () {
        audioGun = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        
        //RayCast from the center of the screen
        Ray myRay = Camera.main.ViewportPointToRay(new Vector3(0.5f,0.5f,0.5f));
        RaycastHit hitInfo;

        if (Input.GetMouseButtonDown(0))//OnClick
        {
            audioGun.Play(0);
            if (Physics.Raycast(myRay, out hitInfo))
            {
               if (hitInfo.collider.tag == "enemy")//Just if it is an enemy
                {
                    
                    Instantiate(explosion, hitInfo.transform.parent.position, hitInfo.transform.parent.rotation);
                    Destroy(hitInfo.transform.parent.gameObject);
                    enemigos--;//Less enemies
                }
            }
        }
    }
    
}
