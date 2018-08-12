using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{

    public float speed;

    private Transform target;
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        { 

        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rb2d = GetComponent<Rigidbody2D>();
    }

}

    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(transform.position, target.position) < 30)
        {
            rb2d.velocity = (target.position - transform.position).normalized * speed;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            rb2d.velocity = new Vector2(0, 0);
        }
    }
}
