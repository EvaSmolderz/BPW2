using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CookieScript : MonoBehaviour {

    private Transform target;
    private Rigidbody2D rb2d;


    // Use this for initialization
    void Start () {
        {

            target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            rb2d = GetComponent<Rigidbody2D>();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }
       
    }
}
